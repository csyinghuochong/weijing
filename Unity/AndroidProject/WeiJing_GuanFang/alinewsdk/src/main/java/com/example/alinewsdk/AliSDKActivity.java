package com.example.alinewsdk;

/**
 * Created by Administrator on 2018/10/17.
 */

        import android.app.Activity;
        import android.os.Handler;
        import android.os.Message;
        import android.text.TextUtils;
        import android.widget.Toast;

        import com.alipay.sdk.app.PayTask;

        import java.lang.reflect.InvocationTargetException;
        import java.lang.reflect.Method;
        import java.util.Map;

/**
 * Created by Administrator on 2018/10/16.
 */

public class AliSDKActivity {

    private String CallAliObjName;//CallAliObjName,CallAliFuncName
    private  String CallAliFuncName;

    private static final int SDK_PAY_FLAG = 1;
    private static final String RESULT_SUCCESS = "9000";
    private static final String TIP_PAY_SUCCESS = "支付成功";
    private static final String TIP_PAY_FAILED = "支付失败";

    //public static AliSDKActivity currentActivity;


    /**
     * unity项目启动时的的上下文
     */
    private Activity _unityActivity;
    /**
     * 获取unity项目的上下文
     * @return
     */
    Activity getActivity(){
        if(null == _unityActivity) {
            try {
                Class<?> classtype = Class.forName("com.unity3d.player.UnityPlayer");
                Activity activity = (Activity) classtype.getDeclaredField("currentActivity").get(classtype);
                _unityActivity = activity;
            } catch (ClassNotFoundException e) {

            } catch (IllegalAccessException e) {

            } catch (NoSuchFieldException e) {

            }
        }
        return _unityActivity;
    }

    /**
     * 调用Unity的方法
     * @param gameObjectName    调用的GameObject的名称
     * @param functionName      方法名
     * @param args              参数
     * @return                  调用是否成功
     */
    boolean callUnity(String gameObjectName, String functionName, String args){
        try {
            Class<?> classtype = Class.forName("com.unity3d.player.UnityPlayer");
            Method method =classtype.getMethod("UnitySendMessage", String.class,String.class,String.class);
            method.invoke(classtype,gameObjectName,functionName,args);
            return true;
        } catch (ClassNotFoundException e) {

        } catch (NoSuchMethodException e) {

        } catch (IllegalAccessException e) {

        } catch (InvocationTargetException e) {

        }
        return false;
    }


    /**
     * Toast显示unity发送过来的内容
     * @param content           消息的内容
     * @return                  调用是否成功
     */
    public boolean showToast(String content){
        Toast.makeText(getActivity(),content,Toast.LENGTH_SHORT).show();
        //这里是主动调用Unity中的方法，该方法之后unity部分会讲到
        callUnity("Main Camera","FromAndroid", "hello unity i'm android");
        return true;
    }


/*
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);

        //currentActivity = this;
    }
    */



    //支付方法,提供给Unity调用,info参数是服务器加签后传递给客户端的最终请求参数.再由客户端调用该方法的时候传递.
    //方法体是官方提供调用支付宝SDK支付的代码.(支付宝APP支付)
    public    void AliPay(final String info,String callObj,String callFunc){
        Toast.makeText(getActivity(), "调用阿里支付API", Toast.LENGTH_SHORT).show();
        CallAliObjName=callObj;//回调的物体名称
        CallAliFuncName=callFunc;//回调的方法名称
        final String orderInfo = info;   // 订单信息



        //支付代码
        Runnable payRunnable = new Runnable() {


            @Override
            public void run() {
                //调用支付请求
                PayTask alipay = new PayTask(getActivity());
                Map<String, String> result = alipay.payV2(orderInfo,true);//ture表示unity到支付宝这个跳转的过程,是否会有一个过渡的动画

                //支付结果回调:就是执行了以上的mHandler
                Message msg = new Message();
                msg.what = SDK_PAY_FLAG;
                msg.obj = result;
                mHandler.sendMessage(msg);
            }
        };
        // 必须异步调用
        Thread payThread = new Thread(payRunnable);
        payThread.start();
    }

    //支付回调:同步通知
    private Handler mHandler = new Handler() {
        public void handleMessage(Message msg) {
            @SuppressWarnings("unchecked")
            PayResult payResult = new PayResult((Map<String, String>) msg.obj);
            //根据支付结果返回的参数进行判断,resultStatus:结果状态
            //如果resultStatus为9000则是支付成功,否则则判定为支付失败
            String resultStatus = payResult.getResultStatus();
            if(TextUtils.equals(resultStatus,RESULT_SUCCESS)){
                //支付成功
                Toast.makeText(getActivity(), TIP_PAY_SUCCESS, Toast.LENGTH_SHORT).show();
                callUnity(CallAliObjName,CallAliFuncName,"支付成功");
                //UnityPlayer.UnitySendMessage(CallAliObjName,CallAliFuncName,"支付成功");
            }
            else {
                //支付失败
                Toast.makeText(getActivity(), TIP_PAY_FAILED, Toast.LENGTH_SHORT).show();
                callUnity(CallAliObjName,CallAliFuncName,"支付失败");
                //UnityPlayer.UnitySendMessage(CallAliObjName,CallAliFuncName,"支付失败");
            }

            //Toast.makeText(MainActivity.this, payResult.getResult(),
            // Toast.LENGTH_LONG).show();

        }
    };


}
