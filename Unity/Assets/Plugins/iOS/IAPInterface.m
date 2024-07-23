//
//  UJSInterface.m
//  Unity-iPhone
//
//  Created by MacMini on 14-5-15.
//
//

#import "IAPInterface.h"
#import <TapOpenApi/TapOpenApi.h>
#import <TapOpenApi/TapOpenApi-Swift.h>

@implementation IAPInterface


#define ARRAY_SIZE(a) sizeof(a)/sizeof(a[0])
 
const char* jailbreak_tool_pathes[] = {
    "/Applications/Cydia.app",
    "/Library/MobileSubstrate/MobileSubstrate.dylib",
    "/bin/bash",
    "/usr/sbin/sshd",
    "/etc/apt"
};
 

//func shareToTapTap() {
//var images: [Data] = []
// let obj = TapShareObj(
// appId: "172664",
// contents: "this is contents",
// groupLabelId: "772618",
// hashtagIds: "8,311",
// footerImages: self.images
// )
// TapApi.send(obj) { result in
// print("result: \(result)")
// }
//}

void FuncTapTapShare(const char *p1,const char *p2 )    
{
    NSString *str = [NSString stringWithFormat:@"%@", 1];
    NSLog(@"###%@",  str);
    
    
    NSString *appId = @"";
    NSString *title = @"";
    NSString *contents = @"";
    NSString *groupLabelId = @"";
    NSString *hashtagIds = @"";
    NSArray *footerImages = @[];
    NSString *failUrl = @"";
    NSString *backUrl = @"";
    
    TapShareObj *obj = [[TapShareObj alloc] initWithAppId:appId
    title:title
    contents:contents
    groupLabelId:groupLabelId
    hashtagIds:hashtagIds
    footerImages:footerImages
    failUrl:failUrl
    backUrl:backUrl];
    [TapApi send:obj completion:^(NSInteger result) {
     // do with result
        NSLog(@"###%@", "FuncTapTapShare.result:  " +  result);
        
    }];
    
    UnitySendMessage("Global", "OnTapTapShareHandler", [str UTF8String] );
}


void CheckIphoneYueyu(const char *p)
{
   
    int t1 = 0;
    int t2 = 0;
    int t3 = 0;
    
  ///  for (int i=0; i<ARRAY_SIZE(jailbreak_tool_pathes); i++) {
  ///      if ([[NSFileManager defaultManager] fileExistsAtPath:[NSString stringWithUTF8String:jailbreak_tool_pathes[i]]]) {
  ///          NSLog(@"The device is jail broken!");
  ///          t1 = 1;
  ///      }
  ///  }
    
    /// 根据是否能打开cydia判断
  ///  if ([[UIApplication sharedApplication] canOpenURL:[NSURL URLWithString:@"cydia://"]]) {
  ///      t2 = 1;
  ///  }
    /// 根据是否能获取所有应用的名称判断 没有越狱的设备是没有读取所有应用名称的权限的。
  ///  if ([[NSFileManager defaultManager] fileExistsAtPath:@"User/Applications/"]) {
  ///      t3 = 1;
  ///  }
    
   /// NSString *str = [ NSString stringWithFormat:@"%d_%d_%d", t1, t2, t3 ];
   /// UnitySendMessage("Global", "OnRecvYueyu", [str UTF8String] );
   [ [ UIApplication sharedApplication] setIdleTimerDisabled:YES ] ;

}

@end

