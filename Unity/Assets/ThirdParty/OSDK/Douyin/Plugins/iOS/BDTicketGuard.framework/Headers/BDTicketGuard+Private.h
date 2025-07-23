//
//  BDTicketGuard+Private.h
//  BDTicketGuard
//
//  Created by ByteDance on 2022/12/21.
//

#import <BDTicketGuard/BDTicketGuard.h>
#import <BDTicketGuard/BDTGKeyPair.h>
#import <BDTicketGuard/BDTGPrivateKeyManager.h>

NS_ASSUME_NONNULL_BEGIN


@interface BDTicketGuard (Private)

@property (class, nonatomic, strong, readonly, nonnull) BDTGPrivateKeyManager *keyManager;

@end


@interface BDTicketGuard (PrivateKeyType)

- (void)resetKeyType:(NSString *_Nonnull)keyType;

@end

NS_ASSUME_NONNULL_END
