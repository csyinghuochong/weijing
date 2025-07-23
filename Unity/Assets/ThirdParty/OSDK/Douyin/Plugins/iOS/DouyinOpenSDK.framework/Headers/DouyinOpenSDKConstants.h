//
//  DouyinOpenSDKConstants.h
//  DouyinOpenPlatformSDK
//
//  Created by arvitwu on 2023/1/12.
//

#ifndef DOUYIN_OPENSDK_CONSTANTS_H_
#define DOUYIN_OPENSDK_CONSTANTS_H_
#import <Foundation/Foundation.h>

/// 当前 SDK 版本号
FOUNDATION_EXTERN NSString * _Nonnull DYOpenSDKVersionFunc(void);
#define DYOpenSDKVersion DYOpenSDKVersionFunc()

/// 网络请求 content type 类型
typedef NS_ENUM(NSInteger, DYOpenNetworkContentType) {
    DYOpenNetworkContentTypeUnknown     = 0,
    DYOpenNetworkContentTypeForm        = 1, // application/x-www-form-urlencoded
    DYOpenNetworkContentTypeJSON        = 2, // application/json
};

#endif
