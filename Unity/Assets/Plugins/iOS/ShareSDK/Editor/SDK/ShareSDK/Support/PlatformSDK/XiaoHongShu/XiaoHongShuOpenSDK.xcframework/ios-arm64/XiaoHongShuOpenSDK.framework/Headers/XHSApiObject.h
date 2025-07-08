//
//
//  XHSApiObject.h
//  XHSOpenSDK
//
//  Created by xuhuiming on 2022/12/9.
//

#import <Foundation/Foundation.h>

///@brief 错误码
typedef NS_ENUM(NSInteger, XHSOpenSDKErrorCode) {
    XHSOpenSDKErrorCodeSuccess             =  0,      /** 成功 */
    XHSOpenSDKErrorCodeCodeCommon          = -1,     /** 普通错误类型 */
    XHSOpenSDKErrorCodeUserCanceled        = -2,     /** 用户点击取消并返回 */
    XHSOpenSDKErrorCodeAuthDenied          = -3,     /** 授权失败 */
    XHSOpenSDKErrorCodeUnsupported         = -4,     /** 不支持 */
    XHSOpenSDKErrorCodeNetDataError        = -5,     /** 网络返回错误，非字典类型，解析不了 */
    XHSOpenSDKErrorCodeAppNotInstalled     = -6,     /** 小红书 App 未安装 */
};

typedef NS_ENUM(NSUInteger, XHSOpenSDKShareAction) {
    XHSOpenSDKShareTypeToPublishMedia,
    XHSOpenSDKShareTypeShareContentToIM,
};

typedef NS_ENUM(NSUInteger, XHSOpenSDKSharePipelineType) {
    XHSOpenSDKSharePipelineTypeAlbum = 0,      // 相册
    XHSOpenSDKSharePipelineTypePasteboard = 1, // 粘贴板
    XHSOpenSDKSharePipelineTypeAuto,           // 混合
};

typedef NS_ENUM(NSUInteger, XHSOpenSDKShareMediaType) {
    XHSOpenSDKShareMediaTypeDefault = 0, // 默认
    XHSOpenSDKShareMediaTypeImage = 1, //!< Map to PHAssetMediaTypeImage
    XHSOpenSDKShareMediaTypeVideo = 2, //!< Map to PHAssetMediaTypeVideo
    XHSOpenSDKShareMediaTypeMix = 3, // Image & Video
};

///@brief 错误码
typedef NS_ENUM(NSInteger, XHSOpenSDKLogLevel) {
    XHSOpenSDKLogLevelNormal = 0,      // 打印日常的日志
    XHSOpenSDKLogLevelDetail = 1,      // 打印详细的日志
};

typedef NS_ENUM(NSInteger, XHSOpenSDKShareRespState) {
    XHSOpenSDKShareRespStateSuccess                         = -10000000, // 成功
    XHSOpenSDKShareRespStateUnknownError                    = -10000001, // 未知或者当前 SDK 版本未分类错误
    XHSOpenSDKShareRespStateSharingError                    = -10000002, // 重复分享，上一次分享流程还没有结束
    XHSOpenSDKShareRespStateVersionError                    = -10000003, // 版本号问题，sdk 版本号太低或者太高、小红书版本号太低或太高
    XHSOpenSDKShareRespStateParamValidError                 = -10000004, // 参数解析错误，获取到的资源和传入的资源类型不一致 difference
    XHSOpenSDKShareRespStateUserNotLogin                    = -10000005, // 用户未登录
    XHSOpenSDKShareRespStateSharePermissionDenied           = -10000014, // 没有足够的权限进行操作，分享或授权之前请确认您的 App 有相关操作权限。可在 open.xiaohongshu.com 的管理中心查看你有哪些权限
    XHSOpenSDKShareRespStateNotHavePasteboardPermission     = -10000015, // 小红书没有粘贴板权限
    XHSOpenSDKShareRespStateNotHavePhotoLibraryPermission   = -10000016, // 小红书没有相册权限
    XHSOpenSDKShareRespStateNetworkError                    = -10000017, // 小红书网络错误
    XHSOpenSDKShareRespStateVideoTimeLimitError             = -10000018, // 视频时长不符合限制
    XHSOpenSDKShareRespStateHandleMediaError                = -10000019, // 处理媒体资源出错
    XHSOpenSDKShareRespStateCancel                          = -10000020, // 用户取消分享
    XHSOpenSDKShareRespStateHaveUploadingTask               = -10000021, // 用户有未完成编辑的发布内容
};

NS_ASSUME_NONNULL_BEGIN

@class XHSOpenSDKShareResponse;

#pragma mark - XHSOpenSDKObject

/// 文本
@interface XHSShareInfoTextContentItem : NSObject

/// 标题
@property (nonatomic, copy, nullable) NSString *title;
/// 正文内容
@property (nonatomic, copy, nullable) NSString *content;

@end;

/// 图片
@interface XHSShareInfoImageItem : NSObject

/// 缩略图数据，imageData是UIImage类型，imageUrl是远端互联网url图片地址类型，二者只有一个生效，UIImage优先级高于url
@property (nonatomic, copy, nullable) NSData *imageData;
/// 图片远程url 或者本地沙盒路径
@property (nonatomic, copy, nullable) NSString *imageUrl;
/// 本地图片相册资源唯一标识
@property (nonatomic, copy, nullable) NSString *imageID;

@end;

/// 视频
@interface XHSShareInfoVideoItem : NSObject

/// 网络视频url 者本地沙盒路径
@property (nonatomic, copy, nullable) NSString *videoUrl;
/// 本地视频资源唯一标识
@property (nonatomic, copy, nullable) NSString *videoID;

/// 网络封面url或本地封面file path 
@property (nonatomic, copy, nullable) NSString *coverUrl;
/// 封面 ID
@property (nonatomic, copy, nullable) NSString *coverID;
/// 封面 data
@property (nonatomic, copy, nullable) NSData *coverImageData;

@end

#pragma mark - XHSOpenSDKBase

/// 该类为小红书终端SDK所有请求类的基类
@interface XHSOpenSDKBaseRequest: NSObject

/// 设置当前请求的额外字段，如无特殊需求可以不设置
@property (nonatomic, copy, nullable) NSDictionary *requestExtraInfo;

@end

/// 该类为小红书终端SDK所有响应类的基类
@interface XHSOpenSDKBaseResponse : NSObject

/// YES for succeess
@property (nonatomic, assign) BOOL isSucceed;

/// error msg
@property (nonatomic, copy, nullable) NSString *errorString;

/// error code
@property (nonatomic, assign) XHSOpenSDKErrorCode errorCode;

@end

#pragma mark - XHSOpenSDKShare

@interface XHSOpenSDKShareRequest : XHSOpenSDKBaseRequest

/// 文本信息
@property (nonatomic, strong, nullable) XHSShareInfoTextContentItem *textContentItem;

/// 图片资源信息
@property (nonatomic, copy, nullable) NSArray<XHSShareInfoImageItem *> *imageInfoItems;

/// 视频资源信息-支持单个视频
@property (nonatomic, copy, nullable) NSArray<XHSShareInfoVideoItem *> *videoInofoItems;

/// 媒体类型(目前只支持图片或视频,可以不传)
@property (nonatomic, assign) XHSOpenSDKShareMediaType mediaType;

/// 分享事件类型(暂时不支持私信,可以不赋值)
@property (nonatomic, assign) XHSOpenSDKShareAction shareAction;

@end

@interface XHSOpenSDKShareResponse : XHSOpenSDKBaseResponse

@property (nonatomic, assign) XHSOpenSDKShareRespState shareState;

@end


NS_ASSUME_NONNULL_END

