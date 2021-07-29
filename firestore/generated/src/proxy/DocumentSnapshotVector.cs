/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace Firebase.Firestore {

internal class DocumentSnapshotVector : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal DocumentSnapshotVector(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(DocumentSnapshotVector obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~DocumentSnapshotVector() {
    Dispose();
  }

  public virtual void Dispose() {

    lock (FirebaseApp.disposeLock) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          FirestoreCppPINVOKE.delete_DocumentSnapshotVector(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(
            null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public DocumentSnapshotVector() : this(FirestoreCppPINVOKE.new_DocumentSnapshotVector(), true) {
    if (FirestoreCppPINVOKE.SWIGPendingException.Pending) throw FirestoreCppPINVOKE.SWIGPendingException.Retrieve();
  }

  public uint Size() {
    uint ret = FirestoreCppPINVOKE.DocumentSnapshotVector_Size(swigCPtr);
    if (FirestoreCppPINVOKE.SWIGPendingException.Pending) throw FirestoreCppPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public DocumentSnapshotProxy GetUnsafeView(uint i) {
    DocumentSnapshotProxy ret = new DocumentSnapshotProxy(FirestoreCppPINVOKE.DocumentSnapshotVector_GetUnsafeView(swigCPtr, i), false);
    if (FirestoreCppPINVOKE.SWIGPendingException.Pending) throw FirestoreCppPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public DocumentSnapshotProxy GetCopy(uint i) {
    DocumentSnapshotProxy ret = new DocumentSnapshotProxy(FirestoreCppPINVOKE.DocumentSnapshotVector_GetCopy(swigCPtr, i), true);
    if (FirestoreCppPINVOKE.SWIGPendingException.Pending) throw FirestoreCppPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void PushBack(DocumentSnapshotProxy value) {
    FirestoreCppPINVOKE.DocumentSnapshotVector_PushBack(swigCPtr, DocumentSnapshotProxy.getCPtr(value));
    if (FirestoreCppPINVOKE.SWIGPendingException.Pending) throw FirestoreCppPINVOKE.SWIGPendingException.Retrieve();
  }

}

}