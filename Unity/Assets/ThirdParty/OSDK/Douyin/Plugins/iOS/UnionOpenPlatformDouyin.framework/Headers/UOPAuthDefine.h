//
//  UOPAuthDefine.h
//  Pods
//
//  Created by yuwei.will on 2023/11/10.
//

#ifndef UOPAuthDefine_h
#define UOPAuthDefine_h

typedef NS_ENUM(NSInteger, UOPAuthErrorCode) {
    UOPAuthSuccess                = 0,  // 正常
    UOPAuthErrorCodeCommon        = -1, // 通用错误
    UOPAuthErrorCodeUserCanceled  = -2, // 用户手动取消
    UOPAuthErrorCodeSendFailed    = -3, // 发送失败
    UOPAuthErrorCodeAuthDenied    = -4, // 分享权限或相册权限异常
    UOPAuthErrorCodeUnsupported   = -5, // 不支持
    UOPAuthErrorCodeNotInstalled  = -6, // 抖音未安装
    
    UOPAuthErrorCodeNotRegister   = -100, // 未初始化
    UOPAuthErrorCodeSystemOff     = -101, // 云控关闭
};

#endif /* UOPAuthDefine_h */
