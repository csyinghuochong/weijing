//
//  BDTGHKDFKit.h
//  BDTicketGuard
//
//  Created by ByteDance on 2022/12/7.
//

#import <Foundation/Foundation.h>

NS_ASSUME_NONNULL_BEGIN


@interface BDTGHKDFKit : NSObject

+ (NSData *)deriveKey:(NSData *)seed info:(NSData *_Nullable)info salt:(NSData *_Nullable)salt outputSize:(int)outputSize;

@end

NS_ASSUME_NONNULL_END
