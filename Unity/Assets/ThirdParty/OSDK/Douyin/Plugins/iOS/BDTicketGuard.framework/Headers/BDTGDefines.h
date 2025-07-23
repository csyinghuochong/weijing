//
//  BDTGDefines.h
//  BDTicketGuard
//
//  Created by ByteDance on 2022/12/19.
//

#import <Foundation/Foundation.h>
#import <BDTicketGuard/BDTGErrorCode.h>

NS_ASSUME_NONNULL_BEGIN

#define BDTGCreateError(errorCode, errorMsgFormat, ...) ([NSError errorWithDomain:BDTGErrorDomain code:errorCode userInfo:@{NSLocalizedDescriptionKey : ([NSString stringWithFormat:errorMsgFormat, ##__VA_ARGS__, nil])}])

#define BDTGCreateReturnError(errorCode, errorMsgFormat, ...)                                            \
    if (error) {                                                                                         \
        *error = [NSError errorWithDomain:BDTGErrorDomain code:errorCode userInfo:@{                     \
            NSLocalizedDescriptionKey : ([NSString stringWithFormat:errorMsgFormat, ##__VA_ARGS__, nil]) \
        }];                                                                                              \
    }

FOUNDATION_EXPORT NSString *const BDTGErrorDomain;

FOUNDATION_EXPORT NSString *const BDTGTicketGuardHeaderTagKey;
FOUNDATION_EXPORT NSString *const BDTGTicketGuardHeaderTargetKey;

FOUNDATION_EXPORT NSString *const BDTGTicketGuardQueryTagKey;
FOUNDATION_EXPORT NSString *const BDTGTicketGuardQueryTargetKey;

NS_ASSUME_NONNULL_END
