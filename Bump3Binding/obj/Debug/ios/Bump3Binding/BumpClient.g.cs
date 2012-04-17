//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;

using System.Drawing;

using System.Runtime.InteropServices;

using MonoTouch;

using MonoTouch.CoreFoundation;

using MonoTouch.CoreMedia;

using MonoTouch.CoreMotion;

using MonoTouch.Foundation;

using MonoTouch.ObjCRuntime;

using MonoTouch.CoreAnimation;

using MonoTouch.CoreLocation;

using MonoTouch.MapKit;

using MonoTouch.UIKit;

using MonoTouch.CoreGraphics;

using MonoTouch.NewsstandKit;

using MonoTouch.GLKit;

using OpenTK;

namespace Bump3Binding {
	[Register("BumpClient", true)]
	public partial class BumpClient : NSObject {
		static IntPtr selSharedClient = Selector.GetHandle ("sharedClient");
		static IntPtr selSetSharedClient_ = Selector.GetHandle ("setSharedClient:");
		static IntPtr selBumpable = Selector.GetHandle ("bumpable");
		static IntPtr selSetBumpable_ = Selector.GetHandle ("setBumpable:");
		static IntPtr selBumpEventBlock_ = Selector.GetHandle ("BumpEventBlock:");
		static IntPtr selBumpChannelConfirmedBlock_ = Selector.GetHandle ("BumpChannelConfirmedBlock:");
		static IntPtr selBumpDataReceivedBlock_ = Selector.GetHandle ("BumpDataReceivedBlock:");
		static IntPtr selBumpConnectionStateChangedBlock_ = Selector.GetHandle ("BumpConnectionStateChangedBlock:");
		static IntPtr selConfigureWithAPIKeyAndUserID_ = Selector.GetHandle ("configureWithAPIKey:andUserID:");
		static IntPtr selSetBumpEventBlock_ = Selector.GetHandle ("setBumpEventBlock:");
		static IntPtr selSetMatchBlock_ = Selector.GetHandle ("setMatchBlock:");
		static IntPtr selSetChannelConfirmedBlock_ = Selector.GetHandle ("setChannelConfirmedBlock:");
		static IntPtr selSetDataReceivedBlock_ = Selector.GetHandle ("setDataReceivedBlock:");
		static IntPtr selSetConnectionStateChangedBlock_ = Selector.GetHandle ("setConnectionStateChangedBlock:");
		static IntPtr selConfirmMatchOnChannel_ = Selector.GetHandle ("confirmMatch:onChannel:");
		static IntPtr selSendDataToChannel_ = Selector.GetHandle ("sendData:toChannel:");
		static IntPtr selUserIDForChannel_ = Selector.GetHandle ("userIDForChannel:");
		static IntPtr selSimulateBump = Selector.GetHandle ("simulateBump");
		
		static IntPtr class_ptr = Class.GetHandle ("BumpClient");
		
		[Export ("init")]
		public  BumpClient () : base (NSObjectFlag.Empty)
		{
			Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.Init);
			
		}

		public BumpClient (NSObjectFlag t) : base (t) {}

		public BumpClient (IntPtr handle) : base (handle) {}

		[Export ("BumpEventBlock:")]
		public unsafe virtual void BumpEvent (BumpEventBlock evt)
		{
			if (evt == null)
				throw new ArgumentNullException ("evt");
			BlockLiteral *block_ptr_evt;
			BlockLiteral block_evt;
			block_evt = new BlockLiteral ();
			block_ptr_evt = &block_evt;
			block_evt.SetupBlock (static_InnerBumpEventBlock, evt);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selBumpEventBlock_, (IntPtr) block_ptr_evt);
			block_ptr_evt->CleanupBlock ();
			
		}
		
		[Export ("BumpEventBlock:")]
		public virtual void BumpMatchBlock (System.UInt64 proposedChannelID)
		{
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt64 (this.Handle, selBumpEventBlock_, proposedChannelID);
		}
		
		[Export ("BumpChannelConfirmedBlock:")]
		public virtual void BumpChannelConfirmedBlock (System.UInt64 channelID)
		{
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt64 (this.Handle, selBumpChannelConfirmedBlock_, channelID);
		}
		
		[Export ("BumpDataReceivedBlock:")]
		public virtual void BumpDataReceivedBlock (System.UInt64 channel, NSData data)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			ApiDefinition.Messaging.void_objc_msgSend_UInt64_IntPtr (this.Handle, selBumpDataReceivedBlock_, channel, data.Handle);
		}
		
		[Export ("BumpConnectionStateChangedBlock:")]
		public virtual void BumpConnectionStateChangedBlock (bool connectedToBumpServer)
		{
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selBumpConnectionStateChangedBlock_, connectedToBumpServer);
		}
		
		[Export ("configureWithAPIKey:andUserID:")]
		public static void Configure (string APIKey, string userID)
		{
			if (APIKey == null)
				throw new ArgumentNullException ("APIKey");
			if (userID == null)
				throw new ArgumentNullException ("userID");
			var nsAPIKey = new NSString (APIKey);
			var nsuserID = new NSString (userID);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (class_ptr, selConfigureWithAPIKeyAndUserID_, nsAPIKey.Handle, nsuserID.Handle);
			nsAPIKey.Dispose ();
			nsuserID.Dispose ();
			
		}
		
		[Export ("setBumpEventBlock:")]
		public unsafe virtual void SetBumpEventBlock (BumpEventBlock bumpEventBlock)
		{
			if (bumpEventBlock == null)
				throw new ArgumentNullException ("bumpEventBlock");
			BlockLiteral *block_ptr_bumpEventBlock;
			BlockLiteral block_bumpEventBlock;
			block_bumpEventBlock = new BlockLiteral ();
			block_ptr_bumpEventBlock = &block_bumpEventBlock;
			block_bumpEventBlock.SetupBlock (static_InnerBumpEventBlock, bumpEventBlock);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetBumpEventBlock_, (IntPtr) block_ptr_bumpEventBlock);
			block_ptr_bumpEventBlock->CleanupBlock ();
			
		}
		
		[Export ("setMatchBlock:")]
		public unsafe virtual void SetMatchBlock (BumpMatchBlock matchBlock)
		{
			if (matchBlock == null)
				throw new ArgumentNullException ("matchBlock");
			BlockLiteral *block_ptr_matchBlock;
			BlockLiteral block_matchBlock;
			block_matchBlock = new BlockLiteral ();
			block_ptr_matchBlock = &block_matchBlock;
			block_matchBlock.SetupBlock (static_InnerBumpMatchBlock, matchBlock);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetMatchBlock_, (IntPtr) block_ptr_matchBlock);
			block_ptr_matchBlock->CleanupBlock ();
			
		}
		
		[Export ("setChannelConfirmedBlock:")]
		public unsafe virtual void SetChannelConfirmedBlock (BumpChannelConfirmedBlock confirmedBlock)
		{
			if (confirmedBlock == null)
				throw new ArgumentNullException ("confirmedBlock");
			BlockLiteral *block_ptr_confirmedBlock;
			BlockLiteral block_confirmedBlock;
			block_confirmedBlock = new BlockLiteral ();
			block_ptr_confirmedBlock = &block_confirmedBlock;
			block_confirmedBlock.SetupBlock (static_InnerBumpChannelConfirmedBlock, confirmedBlock);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetChannelConfirmedBlock_, (IntPtr) block_ptr_confirmedBlock);
			block_ptr_confirmedBlock->CleanupBlock ();
			
		}
		
		[Export ("setDataReceivedBlock:")]
		public unsafe virtual void SetDataReceivedBlock (BumpDataReceivedBlock dataReceivedBlock)
		{
			if (dataReceivedBlock == null)
				throw new ArgumentNullException ("dataReceivedBlock");
			BlockLiteral *block_ptr_dataReceivedBlock;
			BlockLiteral block_dataReceivedBlock;
			block_dataReceivedBlock = new BlockLiteral ();
			block_ptr_dataReceivedBlock = &block_dataReceivedBlock;
			block_dataReceivedBlock.SetupBlock (static_InnerBumpDataReceivedBlock, dataReceivedBlock);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetDataReceivedBlock_, (IntPtr) block_ptr_dataReceivedBlock);
			block_ptr_dataReceivedBlock->CleanupBlock ();
			
		}
		
		[Export ("setConnectionStateChangedBlock:")]
		public unsafe virtual void SetConnectionStateChangedBlock (BumpConnectionStateChangedBlock connectionBlock)
		{
			if (connectionBlock == null)
				throw new ArgumentNullException ("connectionBlock");
			BlockLiteral *block_ptr_connectionBlock;
			BlockLiteral block_connectionBlock;
			block_connectionBlock = new BlockLiteral ();
			block_ptr_connectionBlock = &block_connectionBlock;
			block_connectionBlock.SetupBlock (static_InnerBumpConnectionStateChangedBlock, connectionBlock);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetConnectionStateChangedBlock_, (IntPtr) block_ptr_connectionBlock);
			block_ptr_connectionBlock->CleanupBlock ();
			
		}
		
		[Export ("confirmMatch:onChannel:")]
		public virtual void ConfirmMatch (bool confirmed, System.UInt64 proposedChannelID)
		{
			ApiDefinition.Messaging.void_objc_msgSend_bool_UInt64 (this.Handle, selConfirmMatchOnChannel_, confirmed, proposedChannelID);
		}
		
		[Export ("sendData:toChannel:")]
		public virtual void SendData (NSData data, System.UInt64 channelID)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_UInt64 (this.Handle, selSendDataToChannel_, data.Handle, channelID);
		}
		
		[Export ("userIDForChannel:")]
		public virtual NSString UserIDForChannel (System.UInt64 channelID)
		{
			return (NSString) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_UInt64 (this.Handle, selUserIDForChannel_, channelID));
		}
		
		[Export ("simulateBump")]
		public virtual void SimulateBump ()
		{
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selSimulateBump);
		}
		
		static object __mt_SharedClient_var_static;
		public static BumpClient SharedClient {
			[Export ("sharedClient")]
			get {
				BumpClient ret;
				ret = (BumpClient) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, selSharedClient));
				__mt_SharedClient_var_static = ret;
				return ret;
			}
			
			[Export ("setSharedClient:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (class_ptr, selSetSharedClient_, value.Handle);
			}
		}
		
		public static bool Bumpable {
			[Export ("bumpable")]
			get {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (class_ptr, selBumpable);
			}
			
			[Export ("setBumpable:")]
			set {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (class_ptr, selSetBumpable_, value);
			}
		}
		
		internal delegate void InnerBumpEventBlock (IntPtr block, Bump3Binding.BumpEvent evt);
		static InnerBumpEventBlock static_InnerBumpEventBlock = new InnerBumpEventBlock (TrampolineBumpEventBlock);
		[MonoPInvokeCallback (typeof (InnerBumpEventBlock))]
		static unsafe void TrampolineBumpEventBlock (IntPtr block, Bump3Binding.BumpEvent evt) {
			var descriptor = (BlockLiteral *) block;
			var del = (Bump3Binding.BumpEventBlock) (descriptor->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr (descriptor->global_handle).Target : GCHandle.FromIntPtr (descriptor->local_handle).Target);
			del (evt);
		}
		
		internal delegate void InnerBumpMatchBlock (IntPtr block, System.UInt64 proposedChannelID);
		static InnerBumpMatchBlock static_InnerBumpMatchBlock = new InnerBumpMatchBlock (TrampolineBumpMatchBlock);
		[MonoPInvokeCallback (typeof (InnerBumpMatchBlock))]
		static unsafe void TrampolineBumpMatchBlock (IntPtr block, System.UInt64 proposedChannelID) {
			var descriptor = (BlockLiteral *) block;
			var del = (Bump3Binding.BumpMatchBlock) (descriptor->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr (descriptor->global_handle).Target : GCHandle.FromIntPtr (descriptor->local_handle).Target);
			del (proposedChannelID);
		}
		
		internal delegate void InnerBumpChannelConfirmedBlock (IntPtr block, System.UInt64 channelID);
		static InnerBumpChannelConfirmedBlock static_InnerBumpChannelConfirmedBlock = new InnerBumpChannelConfirmedBlock (TrampolineBumpChannelConfirmedBlock);
		[MonoPInvokeCallback (typeof (InnerBumpChannelConfirmedBlock))]
		static unsafe void TrampolineBumpChannelConfirmedBlock (IntPtr block, System.UInt64 channelID) {
			var descriptor = (BlockLiteral *) block;
			var del = (Bump3Binding.BumpChannelConfirmedBlock) (descriptor->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr (descriptor->global_handle).Target : GCHandle.FromIntPtr (descriptor->local_handle).Target);
			del (channelID);
		}
		
		internal delegate void InnerBumpDataReceivedBlock (IntPtr block, System.UInt64 channel, IntPtr data);
		static InnerBumpDataReceivedBlock static_InnerBumpDataReceivedBlock = new InnerBumpDataReceivedBlock (TrampolineBumpDataReceivedBlock);
		[MonoPInvokeCallback (typeof (InnerBumpDataReceivedBlock))]
		static unsafe void TrampolineBumpDataReceivedBlock (IntPtr block, System.UInt64 channel, IntPtr data) {
			var descriptor = (BlockLiteral *) block;
			var del = (Bump3Binding.BumpDataReceivedBlock) (descriptor->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr (descriptor->global_handle).Target : GCHandle.FromIntPtr (descriptor->local_handle).Target);
			del (channel, (MonoTouch.Foundation.NSData) Runtime.GetNSObject (data));
		}
		
		internal delegate void InnerBumpConnectionStateChangedBlock (IntPtr block, bool connectedToBumpServer);
		static InnerBumpConnectionStateChangedBlock static_InnerBumpConnectionStateChangedBlock = new InnerBumpConnectionStateChangedBlock (TrampolineBumpConnectionStateChangedBlock);
		[MonoPInvokeCallback (typeof (InnerBumpConnectionStateChangedBlock))]
		static unsafe void TrampolineBumpConnectionStateChangedBlock (IntPtr block, bool connectedToBumpServer) {
			var descriptor = (BlockLiteral *) block;
			var del = (Bump3Binding.BumpConnectionStateChangedBlock) (descriptor->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr (descriptor->global_handle).Target : GCHandle.FromIntPtr (descriptor->local_handle).Target);
			del (connectedToBumpServer);
		}
		
	} /* class BumpClient */
	public delegate void BumpEventBlock (BumpEvent evt);
	public delegate void BumpMatchBlock (System.UInt64 proposedChannelID);
	public delegate void BumpChannelConfirmedBlock (System.UInt64 channelID);
	public delegate void BumpDataReceivedBlock (System.UInt64 channel, NSData data);
	public delegate void BumpConnectionStateChangedBlock (bool connectedToBumpServer);
}
