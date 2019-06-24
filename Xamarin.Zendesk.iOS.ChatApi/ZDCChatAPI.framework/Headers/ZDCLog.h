/*
 *
 *  ZDCLog.h
 *  ZDCChat
 *
 *  Created by Zendesk on 09/12/2014.
 *
 *  Copyright (c) 2016 Zendesk. All rights reserved.
 *
 *  By downloading or using the Zendesk Mobile SDK, You agree to the Zendesk Master
 *  Subscription Agreement https://www.zendesk.com/company/customers-partners/#master-subscription-agreement and Application Developer and API License
 *  Agreement https://www.zendesk.com/company/customers-partners/#application-developer-api-license-agreement and
 *  acknowledge that such terms govern Your use of and access to the Mobile SDK.
 *
 */


#import <Foundation/Foundation.h>


/**
 * Log level.
 */
typedef NS_ENUM(NSUInteger, ZDCLogLevel) {

    /// Error logging.
    ZDCLogLevelError        = 0,

    /// Warning logging.
    ZDCLogLevelWarn         = 1,

    /// Info logging.
    ZDCLogLevelInfo         = 2,

    /// Debug logging.
    ZDCLogLevelDebug        = 3,

    /// Verbose logging.
    ZDCLogLevelVerbose      = 4
};


@interface ZDCLog : NSObject


/**
 *  Log an error message.
 *  @param format format string for log message.
 */
+ (void) e:(NSString *)format, ...;

/**
 *  Log a warning message.
 *  @param format format string for log message.
 */
+ (void) w:(NSString *)format, ...;

/**
 *  Log an info message.
 *  @param format format string for log message.
 */
+ (void) i:(NSString *)format, ...;

/**
 *  Log a debug message.
 *  @param format format string for log message.
 */
+ (void) d:(NSString *)format, ...;

/**
 *  Log a verbose message.
 *  @param format format string for log message.
 */
+ (void) v:(NSString *)format, ...;

/**
 *  Set logger enabled
 *  @param enabled enable ZDKLogger wiht YES, disable with NO.
 */
+ (void) enable:(BOOL)enabled;

/*
 * Set the log level, default is ZDCLogLevelWarn
 * @param level the desired log level
 */
+ (void) setLogLevel:(ZDCLogLevel)level;

+ (void) internal:(NSString *)format, ...;

@end

