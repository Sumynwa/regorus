// <auto-generated>
// This code is generated by csbindgen.
// DON'T CHANGE THIS DIRECTLY.
// </auto-generated>
#pragma warning disable CS8500
#pragma warning disable CS8981
using System;
using System.Runtime.InteropServices;


namespace RegorusFFI
{
    internal static unsafe partial class API
    {
        const string __DllName = "regorus_ffi";



        /// <summary>Drop a `RegorusResult`.  `output` and `error_message` strings are not valid after drop.</summary>
        [DllImport(__DllName, EntryPoint = "regorus_result_drop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void regorus_result_drop(RegorusResult r);

        /// <summary>Construct a new Engine  See https://docs.rs/regorus/latest/regorus/struct.Engine.html</summary>
        [DllImport(__DllName, EntryPoint = "regorus_engine_new", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern RegorusEngine* regorus_engine_new();

        /// <summary>Clone a [`RegorusEngine`]  To avoid having to parse same policy again, the engine can be cloned after policies and data have been added.</summary>
        [DllImport(__DllName, EntryPoint = "regorus_engine_clone", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern RegorusEngine* regorus_engine_clone(RegorusEngine* engine);

        [DllImport(__DllName, EntryPoint = "regorus_engine_drop", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void regorus_engine_drop(RegorusEngine* engine);

        /// <summary>Add a policy  The policy is parsed into AST. See https://docs.rs/regorus/latest/regorus/struct.Engine.html#method.add_policy  * `path`: A filename to be associated with the policy. * `rego`: Rego policy.</summary>
        [DllImport(__DllName, EntryPoint = "regorus_engine_add_policy", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern RegorusResult regorus_engine_add_policy(RegorusEngine* engine, byte* path, byte* rego);

        [DllImport(__DllName, EntryPoint = "regorus_engine_add_policy_from_file", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern RegorusResult regorus_engine_add_policy_from_file(RegorusEngine* engine, byte* path);

        /// <summary>Add policy data.  See https://docs.rs/regorus/latest/regorus/struct.Engine.html#method.add_data * `data`: JSON encoded value to be used as policy data.</summary>
        [DllImport(__DllName, EntryPoint = "regorus_engine_add_data_json", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern RegorusResult regorus_engine_add_data_json(RegorusEngine* engine, byte* data);

        [DllImport(__DllName, EntryPoint = "regorus_engine_add_data_from_json_file", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern RegorusResult regorus_engine_add_data_from_json_file(RegorusEngine* engine, byte* path);

        /// <summary>Clear policy data.  See https://docs.rs/regorus/0.1.0-alpha.2/regorus/struct.Engine.html#method.clear_data</summary>
        [DllImport(__DllName, EntryPoint = "regorus_engine_clear_data", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern RegorusResult regorus_engine_clear_data(RegorusEngine* engine);

        /// <summary>Set input.  See https://docs.rs/regorus/0.1.0-alpha.2/regorus/struct.Engine.html#method.set_input * `input`: JSON encoded value to be used as input to query.</summary>
        [DllImport(__DllName, EntryPoint = "regorus_engine_set_input_json", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern RegorusResult regorus_engine_set_input_json(RegorusEngine* engine, byte* input);

        [DllImport(__DllName, EntryPoint = "regorus_engine_set_input_from_json_file", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern RegorusResult regorus_engine_set_input_from_json_file(RegorusEngine* engine, byte* path);

        /// <summary>Evaluate query.  See https://docs.rs/regorus/0.1.0-alpha.2/regorus/struct.Engine.html#method.eval_query * `query`: Rego expression to be evaluate.</summary>
        [DllImport(__DllName, EntryPoint = "regorus_engine_eval_query", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern RegorusResult regorus_engine_eval_query(RegorusEngine* engine, byte* query);


    }

    [StructLayout(LayoutKind.Sequential)]
    internal unsafe partial struct RegorusResult
    {
        public RegorusStatus status;
        public byte* output;
        public byte* error_message;
    }

    [StructLayout(LayoutKind.Sequential)]
    internal unsafe partial struct RegorusEngine
    {
    }


    internal enum RegorusStatus : uint
    {
        RegorusStatusOk,
        RegorusStatusError,
    }


}
