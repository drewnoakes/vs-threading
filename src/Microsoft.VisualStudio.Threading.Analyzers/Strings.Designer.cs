﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.VisualStudio.Threading.Analyzers {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.VisualStudio.Threading.Analyzers.Strings", typeof(Strings).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Await {0} instead.
        /// </summary>
        internal static string AwaitXInstead {
            get {
                return ResourceManager.GetString("AwaitXInstead", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The System.IAsyncDisposable interface is defined in the Microsoft.Bcl.AsyncInterfaces NuGet package..
        /// </summary>
        internal static string SystemIAsyncDisposablePackageNote {
            get {
                return ResourceManager.GetString("SystemIAsyncDisposablePackageNote", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use await instead.
        /// </summary>
        internal static string UseAwaitInstead {
            get {
                return ResourceManager.GetString("UseAwaitInstead", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Await JoinableTaskFactory.SwitchToMainThreadAsync() to switch to the UI thread instead of APIs that can deadlock or require specifying a priority..
        /// </summary>
        internal static string VSTHRD001_MessageFormat {
            get {
                return ResourceManager.GetString("VSTHRD001_MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Avoid legacy thread switching APIs.
        /// </summary>
        internal static string VSTHRD001_Title {
            get {
                return ResourceManager.GetString("VSTHRD001_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use await instead.
        /// </summary>
        internal static string VSTHRD002_CodeFix_Await_Title {
            get {
                return ResourceManager.GetString("VSTHRD002_CodeFix_Await_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Synchronously waiting on tasks or awaiters may cause deadlocks. Use await or JoinableTaskFactory.Run instead..
        /// </summary>
        internal static string VSTHRD002_MessageFormat {
            get {
                return ResourceManager.GetString("VSTHRD002_MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Avoid problematic synchronous waits.
        /// </summary>
        internal static string VSTHRD002_Title {
            get {
                return ResourceManager.GetString("VSTHRD002_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Avoid awaiting or returning a Task representing work that was not started within your context as that can lead to deadlocks.
        ///Start the work within this context, or use JoinableTaskFactory.RunAsync to start the task and await the returned JoinableTask instead..
        /// </summary>
        internal static string VSTHRD003_MessageFormat {
            get {
                return ResourceManager.GetString("VSTHRD003_MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Avoid awaiting foreign Tasks.
        /// </summary>
        internal static string VSTHRD003_Title {
            get {
                return ResourceManager.GetString("VSTHRD003_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Calls to JoinableTaskFactory.SwitchToMainThreadAsync() must be awaited..
        /// </summary>
        internal static string VSTHRD004_MessageFormat {
            get {
                return ResourceManager.GetString("VSTHRD004_MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Await SwitchToMainThreadAsync.
        /// </summary>
        internal static string VSTHRD004_Title {
            get {
                return ResourceManager.GetString("VSTHRD004_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Accessing &quot;{0}&quot; should only be done on the main thread. Await JoinableTaskFactory.SwitchToMainThreadAsync() first..
        /// </summary>
        internal static string VSTHRD010_MessageFormat_Async {
            get {
                return ResourceManager.GetString("VSTHRD010_MessageFormat_Async", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Accessing &quot;{0}&quot; should only be done on the main thread. Call {1}() first..
        /// </summary>
        internal static string VSTHRD010_MessageFormat_Sync {
            get {
                return ResourceManager.GetString("VSTHRD010_MessageFormat_Sync", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invoke single-threaded types on Main thread.
        /// </summary>
        internal static string VSTHRD010_Title {
            get {
                return ResourceManager.GetString("VSTHRD010_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Lazy&lt;Task&lt;T&gt;&gt;.Value can deadlock.
        ///Use AsyncLazy&lt;T&gt; instead..
        /// </summary>
        internal static string VSTHRD011_MessageFormat {
            get {
                return ResourceManager.GetString("VSTHRD011_MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use AsyncLazy&lt;T&gt;.
        /// </summary>
        internal static string VSTHRD011_Title {
            get {
                return ResourceManager.GetString("VSTHRD011_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invoking or blocking on async code in a Lazy&lt;T&gt; value factory can deadlock.
        ///Use AsyncLazy&lt;T&gt; instead..
        /// </summary>
        internal static string VSTHRD011b_MessageFormat {
            get {
                return ResourceManager.GetString("VSTHRD011b_MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Provide an instance of JoinableTaskFactory in this call (or another overload) to avoid deadlocks with the main thread..
        /// </summary>
        internal static string VSTHRD012_MessageFormat {
            get {
                return ResourceManager.GetString("VSTHRD012_MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Provide JoinableTaskFactory where allowed.
        /// </summary>
        internal static string VSTHRD012_Title {
            get {
                return ResourceManager.GetString("VSTHRD012_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Change return type to Task.
        /// </summary>
        internal static string VSTHRD100_CodeFix_Title {
            get {
                return ResourceManager.GetString("VSTHRD100_CodeFix_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Avoid &quot;async void&quot; methods, because any exceptions not handled by the method will crash the process..
        /// </summary>
        internal static string VSTHRD100_MessageFormat {
            get {
                return ResourceManager.GetString("VSTHRD100_MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Avoid async void methods.
        /// </summary>
        internal static string VSTHRD100_Title {
            get {
                return ResourceManager.GetString("VSTHRD100_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Avoid using async lambda for a void returning delegate type, because any exceptions not handled by the delegate will crash the process..
        /// </summary>
        internal static string VSTHRD101_MessageFormat {
            get {
                return ResourceManager.GetString("VSTHRD101_MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Avoid unsupported async delegates.
        /// </summary>
        internal static string VSTHRD101_Title {
            get {
                return ResourceManager.GetString("VSTHRD101_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Limit use of synchronously blocking method calls such as JoinableTaskFactory.Run or Task.Result to public entrypoint members where you must be synchronous. Using it for internal members can needlessly add synchronous frames between asynchronous frames, leading to threadpool exhaustion..
        /// </summary>
        internal static string VSTHRD102_MessageFormat {
            get {
                return ResourceManager.GetString("VSTHRD102_MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Implement internal logic asynchronously.
        /// </summary>
        internal static string VSTHRD102_Title {
            get {
                return ResourceManager.GetString("VSTHRD102_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} synchronously blocks. Await {1} instead..
        /// </summary>
        internal static string VSTHRD103_MessageFormat {
            get {
                return ResourceManager.GetString("VSTHRD103_MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} synchronously blocks. Use await instead..
        /// </summary>
        internal static string VSTHRD103_MessageFormat_UseAwaitInstead {
            get {
                return ResourceManager.GetString("VSTHRD103_MessageFormat_UseAwaitInstead", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Call async methods when in an async method.
        /// </summary>
        internal static string VSTHRD103_Title {
            get {
                return ResourceManager.GetString("VSTHRD103_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expose an async version of this method that does not synchronously block. Then simplify this method to call that async method within a JoinableTaskFactory.Run delegate..
        /// </summary>
        internal static string VSTHRD104_MessageFormat {
            get {
                return ResourceManager.GetString("VSTHRD104_MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Offer async methods.
        /// </summary>
        internal static string VSTHRD104_Title {
            get {
                return ResourceManager.GetString("VSTHRD104_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Avoid method overloads that assume TaskScheduler.Current. Use an overload that accepts a TaskScheduler and specify TaskScheduler.Default (or any other) explicitly..
        /// </summary>
        internal static string VSTHRD105_MessageFormat {
            get {
                return ResourceManager.GetString("VSTHRD105_MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Avoid method overloads that assume TaskScheduler.Current.
        /// </summary>
        internal static string VSTHRD105_Title {
            get {
                return ResourceManager.GetString("VSTHRD105_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to AsyncEventHandler delegates should be invoked via the extension method &quot;TplExtensions.InvokeAsync()&quot; defined in Microsoft.VisualStudio.Threading assembly..
        /// </summary>
        internal static string VSTHRD106_MessageFormat {
            get {
                return ResourceManager.GetString("VSTHRD106_MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use InvokeAsync to raise async events.
        /// </summary>
        internal static string VSTHRD106_Title {
            get {
                return ResourceManager.GetString("VSTHRD106_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Await using expression.
        /// </summary>
        internal static string VSTHRD107_CodeFix_Title {
            get {
                return ResourceManager.GetString("VSTHRD107_CodeFix_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Missing await operator for &quot;using&quot; expression..
        /// </summary>
        internal static string VSTHRD107_MessageFormat {
            get {
                return ResourceManager.GetString("VSTHRD107_MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Await Task within using expression.
        /// </summary>
        internal static string VSTHRD107_Title {
            get {
                return ResourceManager.GetString("VSTHRD107_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Thread affinity checks should be unconditional..
        /// </summary>
        internal static string VSTHRD108_MessageFormat {
            get {
                return ResourceManager.GetString("VSTHRD108_MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Assert thread affinity unconditionally.
        /// </summary>
        internal static string VSTHRD108_Title {
            get {
                return ResourceManager.GetString("VSTHRD108_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Avoid throwing when not on the main thread while in an async or Task-returning method. Switch to the thread required instead..
        /// </summary>
        internal static string VSTHRD109_MessageFormat {
            get {
                return ResourceManager.GetString("VSTHRD109_MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Switch instead of assert in async methods.
        /// </summary>
        internal static string VSTHRD109_Title {
            get {
                return ResourceManager.GetString("VSTHRD109_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Observe the awaitable result of this method call by awaiting it, assigning to a variable, or passing it to another method..
        /// </summary>
        internal static string VSTHRD110_MessageFormat {
            get {
                return ResourceManager.GetString("VSTHRD110_MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Observe result of async calls.
        /// </summary>
        internal static string VSTHRD110_Title {
            get {
                return ResourceManager.GetString("VSTHRD110_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Add .ConfigureAwait(false).
        /// </summary>
        internal static string VSTHRD111_CodeFix_False_Title {
            get {
                return ResourceManager.GetString("VSTHRD111_CodeFix_False_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Add .ConfigureAwait(true).
        /// </summary>
        internal static string VSTHRD111_CodeFix_True_Title {
            get {
                return ResourceManager.GetString("VSTHRD111_CodeFix_True_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Add .ConfigureAwait(bool) to your await expression..
        /// </summary>
        internal static string VSTHRD111_MessageFormat {
            get {
                return ResourceManager.GetString("VSTHRD111_MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use ConfigureAwait(bool).
        /// </summary>
        internal static string VSTHRD111_Title {
            get {
                return ResourceManager.GetString("VSTHRD111_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Add implementation of System.IAsyncDisposable..
        /// </summary>
        internal static string VSTHRD112_CodeFix_Title {
            get {
                return ResourceManager.GetString("VSTHRD112_CodeFix_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Implement the System.IAsyncDisposable interface when implementing the obsolete Microsoft.VisualStudio.Threading.IAsyncDisposable interface..
        /// </summary>
        internal static string VSTHRD112_MessageFormat {
            get {
                return ResourceManager.GetString("VSTHRD112_MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Implement System.IAsyncDisposable.
        /// </summary>
        internal static string VSTHRD112_Title {
            get {
                return ResourceManager.GetString("VSTHRD112_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Add a check for System.IAsyncDisposable in the same code block that checks for Microsoft.VisualStudio.Threading.IAsyncDisposable that behaves similarly..
        /// </summary>
        internal static string VSTHRD113_MessageFormat {
            get {
                return ResourceManager.GetString("VSTHRD113_MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Check for System.IAsyncDisposable.
        /// </summary>
        internal static string VSTHRD113_Title {
            get {
                return ResourceManager.GetString("VSTHRD113_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use &apos;Task.CompletedTask&apos; instead.
        /// </summary>
        internal static string VSTHRD114_CodeFix_CompletedTask {
            get {
                return ResourceManager.GetString("VSTHRD114_CodeFix_CompletedTask", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use &apos;Task.FromResult&apos; instead.
        /// </summary>
        internal static string VSTHRD114_CodeFix_FromResult {
            get {
                return ResourceManager.GetString("VSTHRD114_CodeFix_FromResult", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Avoid returning null from a Task-returning method..
        /// </summary>
        internal static string VSTHRD114_MessageFormat {
            get {
                return ResourceManager.GetString("VSTHRD114_MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Avoid returning a null Task.
        /// </summary>
        internal static string VSTHRD114_Title {
            get {
                return ResourceManager.GetString("VSTHRD114_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use &quot;Async&quot; suffix in names of methods that return an awaitable type..
        /// </summary>
        internal static string VSTHRD200_AddAsync_MessageFormat {
            get {
                return ResourceManager.GetString("VSTHRD200_AddAsync_MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Rename to {0}.
        /// </summary>
        internal static string VSTHRD200_CodeFix_Title {
            get {
                return ResourceManager.GetString("VSTHRD200_CodeFix_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Avoid &quot;Async&quot; suffix in names of methods that do not return an awaitable type..
        /// </summary>
        internal static string VSTHRD200_RemoveAsync_MessageFormat {
            get {
                return ResourceManager.GetString("VSTHRD200_RemoveAsync_MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use &quot;Async&quot; suffix for async methods.
        /// </summary>
        internal static string VSTHRD200_Title {
            get {
                return ResourceManager.GetString("VSTHRD200_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Call ThrowIfCancellationRequested().
        /// </summary>
        internal static string VSTHRD201_CodeFix_Title {
            get {
                return ResourceManager.GetString("VSTHRD201_CodeFix_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Check for cancellation after calling SwitchToMainThreadAsync(CancellationToken)..
        /// </summary>
        internal static string VSTHRD201_MessageFormat {
            get {
                return ResourceManager.GetString("VSTHRD201_MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Check cancellation after SwitchToMainThreadAsync.
        /// </summary>
        internal static string VSTHRD201_Title {
            get {
                return ResourceManager.GetString("VSTHRD201_Title", resourceCulture);
            }
        }
    }
}
