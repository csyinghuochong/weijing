//
//  UOPGameRole.h
//  UnionOpenPlatformDouyin
//
//  Created by ByteDance on 2023/12/4.
//

#import <Foundation/Foundation.h>

NS_ASSUME_NONNULL_BEGIN

/// 当前用户角色信息
@interface UOPGameRole : NSObject
/// 角色ID
@property (nonatomic, copy) NSString *roleID;
/// 角色名称
@property (nonatomic, copy) NSString *roleName;
/// 角色等级
@property (nonatomic, copy) NSString *roleLevel;
/// 区服ID
@property (nonatomic, copy) NSString *serverID;
/// 区服名称
@property (nonatomic, copy) NSString *serverName;
/// 角色头像URL
@property (nonatomic, copy) NSString *avatarUrl;
/// 扩展字段
@property (nonatomic, copy, nullable) NSDictionary *extra;

- (NSString *)fetchJsonExtra;

@end

NS_ASSUME_NONNULL_END
