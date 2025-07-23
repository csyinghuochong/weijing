//
//  UOPDTManager.h
//  UnionOpenPlatformDebugTool
//
//  Created by ByteDance on 2021/11/25.
//

#import <Foundation/Foundation.h>

NS_ASSUME_NONNULL_BEGIN

@interface UOPDTManager : NSObject

+ (instancetype)sharedInstance;

- (NSString *)getVersion;

/// 展示测试工具
/// @discussion 配置文件debug_mode=true时会自动展示，【无需主动调用方法】
/// @attention 会创建 level=UIWindowLevelAlert+1 的 UIWindow，工具会在该window上展示；如果使用了Storyboard并包含SceneDelegate，请保证SceneDelegate中有属性window且已初始化；
- (void)showDebugBall;

/// 隐藏测试工具
- (void)hideDebugBall;

/// 销毁测试工具
/// @attention 需要保证在主线程执行
- (void)destroyDebugBall;

@end

NS_ASSUME_NONNULL_END
