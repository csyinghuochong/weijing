#import <Foundation/Foundation.h>
// 字符串转换 NSString -> char *
extern const char* _Nullable AutonomousStringCopy_initBridge(const char* _Nullable string);

@interface OSDKiOSUtils : NSObject

+ (NSString *_Nullable)convertDictionaryToJsonString:(NSDictionary *_Nullable)dictionary;
+ (NSString *_Nullable)convertArrayToJsonString:(NSArray *_Nullable)array;

+ (NSString *_Nullable)stringWithUTF8String:(const char* _Nullable)charString;
+ (NSArray *_Nullable)arrayWithCSharpCharArray:(const char*_Nullable* _Nullable)CSharpArray arrayLength:(NSInteger)length;
+ (NSDictionary *_Nullable)dictionaryWithJSONString:(NSString *_Nullable)jsonString;

@end

