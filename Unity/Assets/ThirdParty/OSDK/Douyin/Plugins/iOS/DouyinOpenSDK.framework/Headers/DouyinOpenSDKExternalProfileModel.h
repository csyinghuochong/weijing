//
//  DouyinOpenSDKExternalProfileModel.h
//  DouyinOpenPlatformSDK-0ecdc3d1
//
//  Created by ByteDance on 2024/6/4.
//

#import <Foundation/Foundation.h>

NS_ASSUME_NONNULL_BEGIN

@interface DouyinOpenSDKExternalProfileVideoModel: NSObject

@property (nonatomic, strong) NSString *videoId;
@property (nonatomic, strong) NSString *title;
@property (nonatomic, assign) NSInteger height;
@property (nonatomic, assign) NSInteger width;
@property (nonatomic, strong) NSArray<NSString *> *coverURLList; // 封面地址
@property (nonatomic, assign) NSInteger diggCount; // 点赞数
@property (nonatomic, strong, nullable) NSArray<NSString *> *videoURLList; // 视频播放URL
@property (nonatomic, assign) BOOL isClientTop; // 是否是封面视频

@end

@interface DouyinOpenSDKExternalProfileModel : NSObject

@property (nonatomic, copy) NSString *nickName;
@property (nonatomic, copy) NSString *uniqueId; // 抖音号
@property (nonatomic, copy) NSString *signature; // 个人简介
@property (nonatomic, copy) NSString *avatarURLString;
@property (nonatomic, assign) NSInteger fanCount;
@property (nonatomic, assign) NSInteger videoDiggCount;
@property (nonatomic, assign) NSInteger isSecret;
@property (nonatomic, assign) BOOL hasSetCustomVideo;
@property (nonatomic, copy) NSString *showType;
@property (nonatomic, assign) NSInteger customVideoCount;
@property (nonatomic, assign) BOOL authCardVideo;
@property (nonatomic, copy) NSArray<DouyinOpenSDKExternalProfileVideoModel*>* profileVideoModels;
@property (nonatomic, assign) BOOL isViewMore; // 是否展现更多按钮

@end

NS_ASSUME_NONNULL_END
