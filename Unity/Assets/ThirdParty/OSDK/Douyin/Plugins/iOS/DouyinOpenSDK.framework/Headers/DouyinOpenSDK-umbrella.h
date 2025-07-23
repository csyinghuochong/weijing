#ifdef __OBJC__
#import <UIKit/UIKit.h>
#else
#ifndef FOUNDATION_EXPORT
#if defined(__cplusplus)
#define FOUNDATION_EXPORT extern "C"
#else
#define FOUNDATION_EXPORT extern
#endif
#endif
#endif

#import "DouyinOpenSDKAuth.h"
#import "DouyinOpenSDKWebAuthManager.h"
#import "DouyinOpenSDKApplicationDelegate.h"
#import "DouyinOpenSDKConstants.h"
#import "DouyinOpenSDKErrorCode.h"
#import "DouyinOpenSDKObjects.h"
#import "DouyinOpenSDKExternalProfile.h"
#import "DouyinOpenSDKExternalProfileModel.h"
#import "DouyinOpenSDKShare.h"
#import "DYOpenExternalTicketService.h"

FOUNDATION_EXPORT double DouyinOpenSDKVersionNumber;
FOUNDATION_EXPORT const unsigned char DouyinOpenSDKVersionString[];

