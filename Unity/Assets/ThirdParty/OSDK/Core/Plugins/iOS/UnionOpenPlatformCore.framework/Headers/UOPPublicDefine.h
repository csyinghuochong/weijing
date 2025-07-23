//
//  UOPPublicDefine.h
//  UnionOpenPlatformCore
//
//  Created by ByteDance on 2024/3/1.
//

#ifndef UOPPublicDefine_h
#define UOPPublicDefine_h

// 初始化失败错误码
static NSInteger const UOPSDKInitFailedCode = -3;
// 引入模块错误
static NSInteger const UOPSDKInitDependenceFailedCode = -5;
// 未初始化的错误码
static NSInteger const UOPSDKUninitializedCode = -11;
// 依赖组件缺失
static NSInteger const UOPSDKDependenceErrorCode = -12;
// 初始化失败，未开启SDK合作业务
static NSInteger const UOPSDKInitDisenabledCode = -13;

#endif /* UOPPublicDefine_h */
