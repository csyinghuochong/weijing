//
//  UOPManager+IDFA.h
//  UnionOpenPlatformCore
//
//  Created by ByteDance on 2023/10/30.
//

#import <UnionOpenPlatformCore/UOPManager.h>

NS_ASSUME_NONNULL_BEGIN

@interface UOPManager (IDFA)

/// 申请 IDFA 权限
/// @discussion 可选使用，需要在合适时机调用，会向系统申请使用IDFA；系统权限弹窗互相间会存在互斥逻辑，包括但不限于蜂窝网络权限，推送通知权限等；
/// @param handler 申请结果回调；trackEnable: 权限是否申请通过；idfa: 获取到的idfa实际的取值；
+ (void)requestIDFAWithHandler:(void (^)(BOOL trackEnable, NSString *idfa))handler;

@end

NS_ASSUME_NONNULL_END
