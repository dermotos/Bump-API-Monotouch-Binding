using System;
using System.Drawing;

using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace Bump3Binding
{
	
	/* called after a Bump or No Match is detected. */
	//typedef void (^BumpEventBlock)(bump_event event);
	delegate void BumpEventBlock(BumpEvent evt);

	/* called after a Match has occurred. */
	//typedef void (^BumpMatchBlock)(BumpChannelID proposedChannelID);
	delegate void BumpMatchBlock(ulong proposedChannelID);
	
	/* called after both parties to a Match have confirmed the proposed Channel */
	//typedef void (^BumpChannelConfirmedBlock)(BumpChannelID channelID);
	delegate void BumpChannelConfirmedBlock(ulong channelID);
	
	/* called when data has been received from the other end of a Channel */
	//typedef void (^BumpDataReceivedBlock)(BumpChannelID channel, NSData *data);
	delegate void BumpDataReceivedBlock(ulong channel,NSData data);
	
	/* called when the connection to Bump connects or disconnects. */
	//typedef void (^BumpConnectionStateChangedBlock)(BOOL connectedToBumpServer);
	delegate void BumpConnectionStateChangedBlock(bool connectedToBumpServer);
	
	//@interface BumpClient : NSObject {}
	[BaseType (typeof (NSObject))]
	interface BumpClient{
		
		
		//+ (BumpClient *) sharedClient;
		[Static, Export("sharedClient")]
		BumpClient SharedClient { get; set; }
		
		/* called after a Bump or No Match is detected. */
		//typedef void (^BumpEventBlock)(bump_event event);
		
		[Export("BumpEventBlock:")]
		void BumpEvent(BumpEventBlock evt);

		
		/* called after a Match has occurred. */
		//typedef void (^BumpMatchBlock)(BumpChannelID proposedChannelID);
		
		[Export("BumpEventBlock:")]
		void BumpMatchBlock(ulong proposedChannelID);
		
		/* called after both parties to a Match have confirmed the proposed Channel */
		//typedef void (^BumpChannelConfirmedBlock)(BumpChannelID channelID);
		
		[Export("BumpChannelConfirmedBlock:")]
		void BumpChannelConfirmedBlock(ulong channelID);
		
		/* called when data has been received from the other end of a Channel */
		//typedef void (^BumpDataReceivedBlock)(BumpChannelID channel, NSData *data);
		
		[Export("BumpDataReceivedBlock:")]
		void BumpDataReceivedBlock(ulong channel, NSData data);
		
		/* called when the connection to Bump connects or disconnects. */
		//typedef void (^BumpConnectionStateChangedBlock)(BOOL connectedToBumpServer);
		
		[Export("BumpConnectionStateChangedBlock:")]
		void BumpConnectionStateChangedBlock(bool connectedToBumpServer);
		
		
		/* Setter for callback blocks */
		
		//+ (void) configureWithAPIKey : (NSString *) key andUserID : (NSString *) userID;
		[Static, Export("configureWithAPIKey:andUserID:")]
		void Configure(string APIKey, string userID);
		
		//- (void) setBumpEventBlock : (BumpEventBlock) bumpEventBlock;
		[Export("setBumpEventBlock:")]
		void SetBumpEventBlock(BumpEventBlock bumpEventBlock);
		
		//- (void) setMatchBlock : (BumpMatchBlock) matchBlock;
		[Export("setMatchBlock:")]
		void SetMatchBlock(BumpMatchBlock matchBlock);
		
		//- (void) setChannelConfirmedBlock : (BumpChannelConfirmedBlock) confirmedBlock;
		[Export("setChannelConfirmedBlock:")]
		void SetChannelConfirmedBlock(BumpChannelConfirmedBlock confirmedBlock);
		
		//- (void) setDataReceivedBlock : (BumpDataReceivedBlock) dataReceivedBlock;
		[Export("setDataReceivedBlock:")]
		void SetDataReceivedBlock(BumpDataReceivedBlock dataReceivedBlock);
		
		//- (void) setConnectionStateChangedBlock : (BumpConnectionStateChangedBlock) connectionBlock;
		[Export("setConnectionStateChangedBlock:")]
		void SetConnectionStateChangedBlock(BumpConnectionStateChangedBlock connectionBlock);
		
		
		
		///* channel methods */

		//- (void) confirmMatch : (BOOL) confirmed onChannel : (BumpChannelID) proposedChannelID;
		[Export("confirmMatch:onChannel:")]
		void ConfirmMatch(bool confirmed, ulong proposedChannelID);
		
		//- (void) sendData : (NSData *) data toChannel : (BumpChannelID) channelID;
		[Export("sendData:toChannel:")]
		void SendData(NSData data, ulong channelID);
		
		//- (NSString *) userIDForChannel : (BumpChannelID) channelID;
		[Export("userIDForChannel:")]
		NSString UserIDForChannel(ulong channelID);
		
		
		///* turn bumping on/off; defaults to YES. */
		//@property (nonatomic) BOOL bumpable;
		[Static, Export("bumpable")]
		bool Bumpable { get; set; }
		
		
		///* bump simulation */
		//- (void) simulateBump;
		[Export("simulateBump")]
		void SimulateBump();
		
		///* specify dispatch queue that callback blocks should placed on. if unset, the main queue is used. */
		//- (void) setCallbackQueue : (dispatch_queue_t) callbackQueue;
		//[Export("setCallbackQueue:")]
		//void SetCallbackQueue(dispatch_queue_t callbackQueue);
		
		
	}
	// The first step to creating a binding is to add your native library ("libNativeLibrary.a")
	// to the project by right-clicking (or Control-clicking) the folder containing this source
	// file and clicking "Add files..." and then simply select the native library (or libraries)
	// that you want to bind.
	//
	// When you do that, you'll notice that MonoDevelop generates a code-behind file for each
	// native library which will contain a [LinkWith] attribute. MonoDevelop auto-detects the
	// architectures that the native library supports and fills in that information for you,
	// however, it cannot auto-detect any Frameworks or other system libraries that the
	// native library may depend on, so you'll need to fill in that information yourself.
	//
	// Once you've done that, you're ready to move on to binding the API...
	//
	//
	// Here is where you'd define your API definition for the native Objective-C library.
	//
	// For example, to bind the following Objective-C class:
	//
	//     @interface Widget : NSObject {
	//     }
	//
	// The C# binding would look like this:
	//
	//     [BaseType (typeof (NSObject))]
	//     interface Widget {
	//     }
	//
	// To bind Objective-C properties, such as:
	//
	//     @property (nonatomic, readwrite, assign) CGPoint center;
	//
	// You would add a property definition in the C# interface like so:
	//
	//     [Export ("center")]
	//     PointF Center { get; set; }
	//
	// To bind an Objective-C method, such as:
	//
	//     -(void) doSomething:(NSObject *)object atIndex:(NSInteger)index;
	//
	// You would add a method definition to the C# interface like so:
	//
	//     [Export ("doSomething:atIndex:")]
	//     void DoSomething (NSObject object, int index);
	//
	// Objective-C "constructors" such as:
	//
	//     -(id)initWithElmo:(ElmoMuppet *)elmo;
	//
	// Can be bound as:
	//
	//     [Export ("initWithElmo:")]
	//     IntPtr Constructor (ElmoMuppet elmo);
	//
	// For more information, see http://docs.xamarin.com/ios/advanced_topics/binding_objective-c_types
	//
	
	
//	//
////  BumpClient.h
////
////  Created by Thomas Greany on 10/21/11.
////  Copyright 2011 Bump Technologies, Inc. All rights reserved.
////
//
//#import <Foundation/Foundation.h>
//
///* an identifier for a Channel. */
//typedef unsigned long long BumpChannelID;
//
//typedef enum {
//    BUMP_EVENT_BUMP = 0,
//    BUMP_EVENT_NO_MATCH = 1,
//} bump_event;
//
///* called after a Bump or No Match is detected. */
//typedef void (^BumpEventBlock)(bump_event event);
//
///* called after a Match has occurred. */
//typedef void (^BumpMatchBlock)(BumpChannelID proposedChannelID);
//
///* called after both parties to a Match have confirmed the proposed Channel */
//typedef void (^BumpChannelConfirmedBlock)(BumpChannelID channelID);
//
///* called when data has been received from the other end of a Channel */
//typedef void (^BumpDataReceivedBlock)(BumpChannelID channel, NSData *data);
//
///* called when the connection to Bump connects or disconnects. */
//typedef void (^BumpConnectionStateChangedBlock)(BOOL connectedToBumpServer);
//
//@interface BumpClient : NSObject {}
//
///* 
// required configuration prior to accessing the sharedClient
// after configuration, the client will attempt to connect to Bump.
// */
//+ (void) configureWithAPIKey : (NSString *) key andUserID : (NSString *) userID;
//
//
//+ (BumpClient *) sharedClient;
//
///* setters for callback blocks */
//- (void) setBumpEventBlock : (BumpEventBlock) bumpEventBlock;
//- (void) setMatchBlock : (BumpMatchBlock) matchBlock;
//- (void) setChannelConfirmedBlock : (BumpChannelConfirmedBlock) confirmedBlock;
//- (void) setDataReceivedBlock : (BumpDataReceivedBlock) dataReceivedBlock;
//- (void) setConnectionStateChangedBlock : (BumpConnectionStateChangedBlock) connectionBlock;
//
///* channel methods */
//- (void) confirmMatch : (BOOL) confirmed onChannel : (BumpChannelID) proposedChannelID;
//- (void) sendData : (NSData *) data toChannel : (BumpChannelID) channelID;
//- (NSString *) userIDForChannel : (BumpChannelID) channelID;
//
///* turn bumping on/off; defaults to YES. */
//@property (nonatomic) BOOL bumpable;
//
///* bump simulation */
//- (void) simulateBump;
//
///* specify dispatch queue that callback blocks should placed on. if unset, the main queue is used. */
//- (void) setCallbackQueue : (dispatch_queue_t) callbackQueue;
//
//@end

	
	
}

