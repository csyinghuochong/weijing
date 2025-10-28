//
//  UOPDataLinkManager.h
//  UnionOpenPlatformDataLink
//
//  Created by yuwei.will on 2024/7/24.
//

#import <UIKit/UIKit.h>

NS_ASSUME_NONNULL_BEGIN

typedef NS_ENUM(NSInteger, UOPDataLinkEventStatusCode) {
    UOPDataLinkEventStatusSuccess = 0, //成功上报
    
    UOPDataLinkEventStatusUnknown = -1, // 未知
    UOPDataLinkEventStatusBlocked = -2, // 拦截上报
};

@protocol UOPDataLinkManagerDelegate <NSObject>

- (void)onDataLinkReportEvent:(NSString *)eventName code:(NSInteger)code message:(nullable NSString *)message;

@end

@interface UOPDataLinkManager : NSObject

@property (nonatomic, weak) id<UOPDataLinkManagerDelegate> delegate;

/// 识别 Scheme 中 linkID 等相关参数
+ (void)handleOpenURL:(NSURL *)url options:(NSDictionary<UIApplicationOpenURLOptionsKey,id> *)options;

+ (instancetype)sharedInstance;

/// 游戏激活事件
/// - Attention: 如果接入SDK之前用户已激活，那么接入SDK后不应该再上报激活事件
/// - Returns: 接口调用是否成功
- (BOOL)onGameActive;

/// 账号注册事件
/// - Parameters:
///   - gameUserID: 游戏用户ID
/// - gameUserID 需要保障游戏内唯一
/// - Returns: 接口调用是否成功
- (BOOL)onAccountRegister:(NSString *)gameUserID;

/// 角色注册事件
/// - Parameters:
///   - gameUserID: 游戏用户ID
///   - gameRoleID: 游戏角色ID
/// - 可选，没有角色概念的游戏可以不调用
/// - 账号注册事件和角色注册事件可以同时调用
/// - gameUserID，gameRoleID 需要保障游戏内唯一
/// - Returns: 接口调用是否成功
- (BOOL)onRoleRegister:(NSString *)gameUserID
            gameRoleID:(NSString *)gameRoleID;

/// 账号登录事件
/// - Parameters:
///   - gameUserID: 游戏用户ID
///   - lastLoginTime: 上次登录时间，单位s
/// - gameUserID 需要保障游戏内唯一
/// - lastLoginTime 缺省、默认值传0
/// - Returns: 接口调用是否成功
- (BOOL)onAccountLogin:(NSString *)gameUserID
         lastLoginTime:(int64_t)lastLoginTime;

/// 角色登录事件
/// - Parameters:
///   - gameUserID: 游戏用户ID
///   - gameRoleID: 游戏角色ID
///   - lastRoleLoginTime: 上次角色登录时间，单位s
/// - 可选，没有角色概念的游戏可以不调用
/// - 账号登录事件和角色登录事件可以同时调用
/// - gameUserID，gameRoleID 需要保障游戏内唯一
/// - lastRoleLoginTime 缺省、默认值传0
/// - Returns: 接口调用是否成功
- (BOOL)onRoleLogin:(NSString *)gameUserID
         gameRoleID:(NSString *)gameRoleID
  lastRoleLoginTime:(int64_t)lastRoleLoginTime;

/// 用户付费事件
/// - Parameters:
///   - gameUserID: 游戏用户ID
///   - gameRoleID: 游戏角色ID
///   - gameOrderID: 订单ID
///   - totalAmount: 订单金额，单位分
///   - productID: 商品ID
///   - productName: 商品名称
///   - productDesc: 商品描述
/// - gameUserID，gameRoleID 需要保障游戏内唯一
/// - 没有角色概念的游戏 gameRoleID 传空字符串
/// - Returns: 接口调用是否成功
- (BOOL)onPay:(NSString *)gameUserID
   gameRoleID:(NSString * _Nullable)gameRoleID
  gameOrderID:(NSString *)gameOrderID
  totalAmount:(int64_t)totalAmount
    productID:(NSString * _Nullable)productID
  productName:(NSString * _Nullable)productName
  productDesc:(NSString * _Nullable)productDesc;

/// 用户特殊付费事件
/// - Parameters:
///   - gameUserID: 游戏用户ID
///   - gameRoleID: 游戏角色ID
///   - gameOrderID: 订单ID
///   - payType: 付费类型
///   - payRangeMin: 本次付费所属的付费范围最小值，单位分
///   - payRangeMax: 本次付费所属的付费范围最大值，单位分
///   - productID: 商品ID
///   - productName: 商品名称
///   - productDesc: 商品描述
/// - gameUserID，gameRoleID 需要保障游戏内唯一
/// - 没有角色概念的游戏 gameRoleID 传空字符串
/// - payType 区分本次付费金额的大小，字段取值 high / medium / low，允许传入空字符串，付费范围由接入方自行定义
/// - payRangeMin / payRangeMax 缺省、默认值传0
/// - Returns: 接口调用是否成功
- (BOOL)onPaySpecial:(NSString *)gameUserID
          gameRoleID:(NSString * _Nullable)gameRoleID
         gameOrderID:(NSString * _Nullable)gameOrderID
             payType:(NSString * _Nullable)payType
         payRangeMin:(int64_t)payRangeMin
         payRangeMax:(int64_t)payRangeMax
           productID:(NSString * _Nullable)productID
         productName:(NSString * _Nullable)productName
         productDesc:(NSString * _Nullable)productDesc;

/// 自定义事件
/// - 版本向后兼容使用
/// - Parameters:
///   - eventName: 事件名
///   - params: 事件入参
/// - Attention: 请在技术支持协助下使用，无需主动调用该方法
/// - Returns: 接口调用是否成功
- (BOOL)customEvent:(NSString *)eventName
             params:(NSDictionary * _Nullable)params;

@end

NS_ASSUME_NONNULL_END
