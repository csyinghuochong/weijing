//
//  DouyinOpenSDKObjects.h
//
//  Created by ByteDance on 2019/7/8.
//  Copyright (c) 2018年 ByteDance Ltd. All rights reserved.
//

#import <Foundation/Foundation.h>
#import "DouyinOpenSDKErrorCode.h"

@class DouyinOpenSDKBaseResponse;

typedef NS_ENUM(NSInteger, DouyinOpenSDKTargetAppType) {
    DouyinOpenSDKTargetAuto,
    DouyinOpenSDKTargetDouyinLiteApp,
    DouyinOpenSDKTargetDouyinApp,
    DouyinOpenSDKTargetDouyinHTSApp,
};

// extraInfo 里的 key，字符串枚举
typedef NSString * _Nullable DYOpenExtraInfoKey NS_TYPED_ENUM;

NS_ASSUME_NONNULL_BEGIN
typedef void(^DouyinOpenSDKRequestCompletedBlock) (DouyinOpenSDKBaseResponse *resp);

@interface DouyinOpenSDKBaseRequest : NSObject

/**
 Unique id flag the request.
 */
@property (nonatomic, copy, readwrite, nonnull) NSString *requestId;

/// Passing additional sharing requests param
@property (nonatomic, copy, nullable) NSDictionary *extraInfo;

/// target app
@property (nonatomic, assign) DouyinOpenSDKTargetAppType targetApp;

/// other user info dict
@property (nonatomic, strong, nullable) NSMutableDictionary<NSObject *, id> *otherInfoDict;

@end

@interface DouyinOpenSDKBaseResponse : NSObject

/// YES for succeess
@property (nonatomic, readonly, assign) BOOL isSucceed;

/// Level 1 code
@property (nonatomic, assign) DouyinOpenSDKErrorCode errCode;

/// Level 2 code
@property (nonatomic, assign) DouyinOpenSDKSubCode subErrorCode;

/// error msg
@property (nonatomic, copy, nullable) NSString *errString;

@property (nonatomic, copy, nullable) NSDictionary *extraInfo;

@end

NS_ASSUME_NONNULL_END
