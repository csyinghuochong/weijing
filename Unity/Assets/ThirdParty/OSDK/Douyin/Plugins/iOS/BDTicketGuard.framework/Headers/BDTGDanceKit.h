//
//  BDTGDanceKit.h
//  BDTicketGuard
//
//  Created by ByteDance on 2022/12/20.
//

#import <Foundation/Foundation.h>

NS_ASSUME_NONNULL_BEGIN

#define BDTGTimestamp (CACurrentMediaTime() * 1000)
#define BDTGTimestampStart NSTimeInterval startTimestamp = (CACurrentMediaTime() * 1000)

#define BDTGLogInfo(format, ...) [BDTGLogKit info:([NSString stringWithFormat:format, ##__VA_ARGS__, nil])]
#define BDTGLogError(format, ...) [BDTGLogKit error:([NSString stringWithFormat:format, ##__VA_ARGS__, nil])]

FOUNDATION_EXPORT void BDTGAssert(BOOL condition, NSString *_Nullable desc);

#ifndef BDTG_isEmptyString
FOUNDATION_EXPORT BOOL BDTG_isEmptyString(id param);
#endif

#ifndef BDTG_isEmptyDictionary
FOUNDATION_EXPORT BOOL BDTG_isEmptyDictionary(id param);
#endif


@interface BDTGDanceKit : NSObject

+ (NSString *)base64EncodedFromString:(NSString *)fromString;
+ (NSString *)base64DecodedFromString:(NSString *)fromString;
+ (NSData *)hexDecodedFromString:(NSString *)fromString;
+ (NSString *)hexEncodedFromData:(NSData *)fromData;

+ (NSDictionary *)jsonDecodedFromString:(NSString *)fromString;
+ (NSString *)jsonEncodedFromDictionary:(NSDictionary *)fromDictionary;

+ (NSString *)stringValueForKey:(id<NSCopying>)key inDictionary:(NSDictionary *)fromDictionary;
+ (NSDictionary *)dictionaryValueForKey:(id<NSCopying>)key inDictionary:(NSDictionary *)fromDictionary;

+ (NSString *)queryItemValueForKey:(NSString *)key inURL:(NSURL *)URL;

@end


@interface BDTGDanceKit (Adapter)

+ (void)attachObject:(id)obj toObject:(id)toObj withKey:(NSString *)key;
+ (id _Nullable)getAttachedObjectFromObject:(id)obj withKey:(NSString *)key;

@end

#pragma mark - Log


@interface BDTGLogKit : BDTGDanceKit

@end


@interface BDTGLogKit (Adapter)

+ (void)info:(NSString *)log;

+ (void)error:(NSString *)log;

@end

#pragma mark - Assert


@interface BDTGAssertKit : BDTGDanceKit

@end


@interface BDTGAssertKit (Adapter)

+ (void)assert:(BOOL)condition desc:(NSString *)desc;

@end

#pragma mark - Tracker


@interface BDTGTrackerKit : BDTGDanceKit

@end


@interface BDTGTrackerKit (Adapter)

+ (void)eventV3:(NSString *)eventName params:(NSDictionary *)params;

@end

#pragma mark - Storage


@interface BDTGStorageKit : BDTGDanceKit

@end


@interface BDTGStorageKit (Adapter)

+ (BOOL)getBoolForKey:(NSString *)key;
+ (void)setBool:(BOOL)value forKey:(NSString *)key;

+ (NSString *_Nullable)getStringForKey:(NSString *)key;
+ (void)setString:(NSString *_Nullable)value forKey:(NSString *)key;

+ (NSData *_Nullable)getDataForKey:(NSString *)key;
+ (void)setObject:(nullable id)value forKey:(NSString *)key;

@end

NS_ASSUME_NONNULL_END
