//
//  OSDKiOSUtils.m
//  Unity-iPhone
//
//  Created by bytedance on 2023/10/26.
//

#import "OSDKiOSUtils.h"
#import <UIKit/UIKit.h>

const char* _Nullable AutonomousStringCopy_initBridge(const char* _Nullable string)
{
    if (string == NULL) {
        return NULL;
    }
    char* res = (char*)malloc(strlen(string) + 1);
    strcpy(res, string);
    return res;
}

@implementation OSDKiOSUtils

#pragma mark - Helper
+ (NSString *_Nullable)convertArrayToJsonString:(NSArray *_Nullable)array {
    if (array == nil) return @"";
    
    NSError *error;
    NSData *jsonData = [NSJSONSerialization dataWithJSONObject:array
                                                       options:NSJSONWritingFragmentsAllowed
                                                         error:&error];
    NSString *jsonString = @"";
    if(!error) {
        jsonString = [[NSString alloc] initWithData:jsonData encoding:NSUTF8StringEncoding];
    }
    return jsonString;
}

+ (NSString *_Nullable)convertDictionaryToJsonString:(NSDictionary *_Nullable)dictionary {
    if (dictionary == nil) return @"";
    
    NSError *error;
    NSData *jsonData = [NSJSONSerialization dataWithJSONObject:dictionary
                                                       options:NSJSONWritingPrettyPrinted
                                                         error:&error];
    NSString *jsonString = @"";
    if(!error) {
        jsonString = [[NSString alloc] initWithData:jsonData encoding:NSUTF8StringEncoding];
    }
    return jsonString;
}

+ (NSString *_Nullable)stringWithUTF8String:(const char*_Nullable)charString {
    if (charString) {
        return [NSString stringWithUTF8String:charString];
    }
    return @"";
}

+ (NSArray *_Nullable)arrayWithCSharpCharArray:(const char*_Nullable* _Nullable)CSharpArray arrayLength:(NSInteger)length {
    if (length == 0) {
        return nil;
    }
    NSMutableArray *array = [NSMutableArray array];
    for (int i = 0; i < length; i++) {
        NSString *item = [self stringWithUTF8String:CSharpArray[i]];
        if (item) {
            [array addObject:item];
        }
    }
    return array.copy;
}

+ (NSDictionary *_Nullable)dictionaryWithJSONString:(NSString *_Nullable)jsonString; {
    if (!jsonString) {
        return nil;
    }
    NSData *jsonData = [jsonString dataUsingEncoding:NSUTF8StringEncoding];
    NSError *err;
    NSDictionary *dict = [NSJSONSerialization JSONObjectWithData:jsonData options:NSJSONReadingMutableContainers error:&err];
    if (err) {
        return nil;
    }
    return dict;
}

@end

#if defined (__cplusplus)
extern "C" {
#endif

void OSDK_iOSCopyToClipboard(const char* text) 
{
    if (text == NULL) {
        return;
    }
    UIPasteboard *pasteBoard = [UIPasteboard generalPasteboard];
    pasteBoard.string = [[NSString alloc] initWithUTF8String:text];
}

#if defined (__cplusplus)
}
#endif