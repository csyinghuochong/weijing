//
//  UOPAuthRequest.h
//  UnionOpenPlatform
//
//  Created by ByteDance on 2021/6/3.
//

#import <Foundation/Foundation.h>

NS_ASSUME_NONNULL_BEGIN

@interface UOPAuthRequest : NSObject

/** 需要使用的的第三方授权平台APP所需权限,目前仅头条、抖音等公司内app使用,空值时 默认权限为user_info **/
@property (nonatomic, strong, nullable) NSOrderedSet<NSString *> *permissions;

/**
 应用程序向第三方平台申请的附加权限类型，用户可以勾选是否给予这部分权限，最终在平台授权完成后根据第三方平台的实际授权结果返回给应用；
 @key permission 权限
 @key defaultChecked 初始勾选状态，@"1"表示勾选，@"0"表示未勾选
 例如 [NSOrderedSet orderedSetWithObjects:@{@"permission":@"mobile",@"defaultChecked":@"0"}, ..., nil]
 */
@property (nonatomic, strong, nullable) NSOrderedSet<NSDictionary<NSString *,NSString *> *> *additionalPermissions;

/// 透传的额外信息
/// @discussion 正常情况不设置留空即可
@property (nonatomic, strong) NSDictionary *extraInfo;

@property (nonatomic, assign) BOOL mustPortrait API_DEPRECATED("This property was deprecated, please remove the calling.", ios(8.0, 10.0));

@end

NS_ASSUME_NONNULL_END
