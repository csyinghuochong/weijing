package com.guangying.weijing2;

import android.content.Intent;
import android.util.Log;

import com.quicksdk.QuickSdkSplashActivity;

public class SplashActivity extends QuickSdkSplashActivity {

    @Override
    public int getBackgroundColor() {
        return 0;
    }

    @Override
    public void onSplashStop() {

        Log.i("SplashActivity", "onSplashStop");
        Intent intent = new Intent(this, MainActivity.class);
        startActivity(intent);
        finish();
    }
}
