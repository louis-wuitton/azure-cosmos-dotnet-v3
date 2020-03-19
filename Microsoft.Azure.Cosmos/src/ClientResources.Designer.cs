﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Azure.Cosmos {
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
    internal class ClientResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ClientResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Azure.Cosmos.ClientResources", typeof(ClientResources).Assembly);
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
        ///   Looks up a localized string similar to Sorry, we are currently experiencing high demand in this region, and cannot fulfill your request at this time. We work continuously to bring more and more capacity online, and encourage you to try again shortly. Please do not hesitate to contact us via Azure support at any time or for any reason using this link http://aka.ms/azuresupport..
        /// </summary>
        internal static string AllServicePoolsEmpty {
            get {
                return ResourceManager.GetString("AllServicePoolsEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The client does not have any valid token for the requested resource {0}..
        /// </summary>
        internal static string AuthTokenNotFound {
            get {
                return ResourceManager.GetString("AuthTokenNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Query expression is invalid, member {0} of type {1} is invalid..
        /// </summary>
        internal static string BadQuery_IllegalMemberAccess {
            get {
                return ResourceManager.GetString("BadQuery_IllegalMemberAccess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Query expression is invalid, expression {0} is unsupported in this context. Supported expressions are MemberAccess and ArrayIndex..
        /// </summary>
        internal static string BadQuery_InvalidArrayIndexExpression {
            get {
                return ResourceManager.GetString("BadQuery_InvalidArrayIndexExpression", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Type {0} for an array index parameter is invalid. Array index parameter must be int..
        /// </summary>
        internal static string BadQuery_InvalidArrayIndexType {
            get {
                return ResourceManager.GetString("BadQuery_InvalidArrayIndexType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Query expression is invalid, expression {0} must either have LHS or RHS as constant..
        /// </summary>
        internal static string BadQuery_InvalidComparison {
            get {
                return ResourceManager.GetString("BadQuery_InvalidComparison", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Query expression is invalid, expression {0} of type {1} cannot be used in this context..
        /// </summary>
        internal static string BadQuery_InvalidComparisonType {
            get {
                return ResourceManager.GetString("BadQuery_InvalidComparisonType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Query expression is invalid, expression {0} is unsupported. Supported expressions are &apos;Queryable.Where&apos;, &apos;Queryable.Select&apos; &amp; &apos;Queryable.SelectMany&apos;.
        /// </summary>
        internal static string BadQuery_InvalidExpression {
            get {
                return ResourceManager.GetString("BadQuery_InvalidExpression", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Query expression is invalid, expression {0} is not allowed in this context..
        /// </summary>
        internal static string BadQuery_InvalidLeftExpression {
            get {
                return ResourceManager.GetString("BadQuery_InvalidLeftExpression", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Query expression is invalid, expression {0} is unsupported in this context. Supported expressions are parameter reference, array index and property reference..
        /// </summary>
        internal static string BadQuery_InvalidMemberAccessExpression {
            get {
                return ResourceManager.GetString("BadQuery_InvalidMemberAccessExpression", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Query expression is invalid, method call {0} is not allowed at this context. Allowed methods are {1}..
        /// </summary>
        internal static string BadQuery_InvalidMethodCall {
            get {
                return ResourceManager.GetString("BadQuery_InvalidMethodCall", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to QueryType {0} is not supported..
        /// </summary>
        internal static string BadQuery_InvalidQueryType {
            get {
                return ResourceManager.GetString("BadQuery_InvalidQueryType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Query expression is invalid, expression return type {0} is unsupported. Query must evaluate to IEnumerable..
        /// </summary>
        internal static string BadQuery_InvalidReturnType {
            get {
                return ResourceManager.GetString("BadQuery_InvalidReturnType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Query expression is invalid, expression {0} contains too many arguments. .
        /// </summary>
        internal static string BadQuery_TooManySelectManyArguments {
            get {
                return ResourceManager.GetString("BadQuery_TooManySelectManyArguments", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occured while evaluating the transform expression {0}..
        /// </summary>
        internal static string BadQuery_TransformQueryException {
            get {
                return ResourceManager.GetString("BadQuery_TransformQueryException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Session object retrieved from client with endpoint {0} cannot be used on a client initialized to endpoint {1}..
        /// </summary>
        internal static string BadSession {
            get {
                return ResourceManager.GetString("BadSession", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The batch request did not have any operations to be executed..
        /// </summary>
        internal static string BatchNoOperations {
            get {
                return ResourceManager.GetString("BatchNoOperations", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to One or more batch operations are larger than the allowed limit..
        /// </summary>
        internal static string BatchOperationTooLarge {
            get {
                return ResourceManager.GetString("BatchOperationTooLarge", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to One or more request options provided on the batch request are not supported..
        /// </summary>
        internal static string BatchRequestOptionNotSupported {
            get {
                return ResourceManager.GetString("BatchRequestOptionNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This batch request cannot be executed as it is larger than the allowed limit. Please reduce the number of operations in the batch and try again..
        /// </summary>
        internal static string BatchTooLarge {
            get {
                return ResourceManager.GetString("BatchTooLarge", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Binary operator &apos;{0}&apos; is not supported..
        /// </summary>
        internal static string BinaryOperatorNotSupported {
            get {
                return ResourceManager.GetString("BinaryOperatorNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Constant of type &apos;{0}&apos; is not supported..
        /// </summary>
        internal static string ConstantTypeIsNotSupported {
            get {
                return ResourceManager.GetString("ConstantTypeIsNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Constructor invocation is not supported..
        /// </summary>
        internal static string ConstructorInvocationNotSupported {
            get {
                return ResourceManager.GetString("ConstructorInvocationNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A data encryption key with the provided name was not found - please ensure it has been created..
        /// </summary>
        internal static string DataEncryptionKeyNotFound {
            get {
                return ResourceManager.GetString("DataEncryptionKeyNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The client was not configured to allow for encryption. Create the client by using cosmosClientBuilder.WithDataEncryptionKeyProvider..
        /// </summary>
        internal static string DataEncryptionKeyProviderNotConfigured {
            get {
                return ResourceManager.GetString("DataEncryptionKeyProviderNotConfigured", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expected valid byte[] value for {0} and string value for {1} when either property is set..
        /// </summary>
        internal static string EpkPropertiesPairingExpected {
            get {
                return ResourceManager.GetString("EpkPropertiesPairingExpected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expected a static IQueryable or IEnumerable extension method, received an instance method..
        /// </summary>
        internal static string ExpectedMethodCallsMethods {
            get {
                return ResourceManager.GetString("ExpectedMethodCallsMethods", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expression with NodeType &apos;{0}&apos; is not supported..
        /// </summary>
        internal static string ExpressionTypeIsNotSupported {
            get {
                return ResourceManager.GetString("ExpressionTypeIsNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expression tree cannot be processed because evaluation of Spatial expression failed..
        /// </summary>
        internal static string FailedToEvaluateSpatialExpression {
            get {
                return ResourceManager.GetString("FailedToEvaluateSpatialExpression", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot parse &apos;{0}&apos; as a valid FeedToken..
        /// </summary>
        internal static string FeedToken_CannotParse {
            get {
                return ResourceManager.GetString("FeedToken_CannotParse", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot define EffectivePartitionKeyRouting and FeedToken simultaneously..
        /// </summary>
        internal static string FeedToken_EffectivePartitionKeyRouting {
            get {
                return ResourceManager.GetString("FeedToken_EffectivePartitionKeyRouting", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expected FeedTokenInternal instance..
        /// </summary>
        internal static string FeedToken_InvalidImplementation {
            get {
                return ResourceManager.GetString("FeedToken_InvalidImplementation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Provide a value greater than zero..
        /// </summary>
        internal static string FeedToken_MaxTokensOutOfRange {
            get {
                return ResourceManager.GetString("FeedToken_MaxTokensOutOfRange", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The provided string does not represent any known FeedToken format..
        /// </summary>
        internal static string FeedToken_UnknownFormat {
            get {
                return ResourceManager.GetString("FeedToken_UnknownFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unrecognized Feed Token type..
        /// </summary>
        internal static string FeedToken_UnrecognizedFeedToken {
            get {
                return ResourceManager.GetString("FeedToken_UnrecognizedFeedToken", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Input is not of type IDocumentQuery..
        /// </summary>
        internal static string InputIsNotIDocumentQuery {
            get {
                return ResourceManager.GetString("InputIsNotIDocumentQuery", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Incorrect number of arguments for method &apos;{0}&apos;. Expected &apos;{1}&apos; but received &apos;{2}&apos;..
        /// </summary>
        internal static string InvalidArgumentsCount {
            get {
                return ResourceManager.GetString("InvalidArgumentsCount", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This method should only be called within Linq expression to Invoke a User-defined function..
        /// </summary>
        internal static string InvalidCallToUserDefinedFunctionProvider {
            get {
                return ResourceManager.GetString("InvalidCallToUserDefinedFunctionProvider", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Range low value must be less than or equal the high value..
        /// </summary>
        internal static string InvalidRangeError {
            get {
                return ResourceManager.GetString("InvalidRangeError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Encryption options may not be specified on this request..
        /// </summary>
        internal static string InvalidRequestWithEncryptionOptions {
            get {
                return ResourceManager.GetString("InvalidRequestWithEncryptionOptions", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Received an invalid response from the server..
        /// </summary>
        internal static string InvalidServerResponse {
            get {
                return ResourceManager.GetString("InvalidServerResponse", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The count value provided for a Skip expression must be a non-negative integer..
        /// </summary>
        internal static string InvalidSkipValue {
            get {
                return ResourceManager.GetString("InvalidSkipValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The count value provided for a Take expression must be a non-negative integer..
        /// </summary>
        internal static string InvalidTakeValue {
            get {
                return ResourceManager.GetString("InvalidTakeValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Method &apos;{0}&apos; can not be invoked for type &apos;{1}&apos;. Supported types are &apos;[{2}]&apos;..
        /// </summary>
        internal static string InvalidTypesForMethod {
            get {
                return ResourceManager.GetString("InvalidTypesForMethod", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The key wrapping provider configured was unable to unwrap the wrapped key correctly..
        /// </summary>
        internal static string KeyWrappingDidNotRoundtrip {
            get {
                return ResourceManager.GetString("KeyWrappingDidNotRoundtrip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to MediaLink is invalid.
        /// </summary>
        internal static string MediaLinkInvalid {
            get {
                return ResourceManager.GetString("MediaLinkInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Member binding is not supported..
        /// </summary>
        internal static string MemberBindingNotSupported {
            get {
                return ResourceManager.GetString("MemberBindingNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Method &apos;{0}&apos; is not supported..
        /// </summary>
        internal static string MethodNotSupported {
            get {
                return ResourceManager.GetString("MethodNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Not supported..
        /// </summary>
        internal static string NotSupported {
            get {
                return ResourceManager.GetString("NotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Method &apos;{0}&apos; is not supported. Only LINQ Methods are supported..
        /// </summary>
        internal static string OnlyLINQMethodsAreSupported {
            get {
                return ResourceManager.GetString("OnlyLINQMethodsAreSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to extract partition key from document. Ensure that you have provided a valid PartitionKeyValueExtractor function..
        /// </summary>
        internal static string PartitionKeyExtractError {
            get {
                return ResourceManager.GetString("PartitionKeyExtractError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The requested partition key path &apos;{0}&apos; does not match existing Container &apos;{1}&apos; with partition key path &apos;{2}&apos;.
        /// </summary>
        internal static string PartitionKeyPathConflict {
            get {
                return ResourceManager.GetString("PartitionKeyPathConflict", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Partition property not found in the document..
        /// </summary>
        internal static string PartitionPropertyNotFound {
            get {
                return ResourceManager.GetString("PartitionPropertyNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An IPartitionResolver already exists for this database.
        /// </summary>
        internal static string PartitionResolver_DatabaseAlreadyExist {
            get {
                return ResourceManager.GetString("PartitionResolver_DatabaseAlreadyExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No IPartitionResolver available for this database.
        /// </summary>
        internal static string PartitionResolver_DatabaseDoesntExist {
            get {
                return ResourceManager.GetString("PartitionResolver_DatabaseDoesntExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Only path expressions are supported for SelectMany..
        /// </summary>
        internal static string PathExpressionsOnly {
            get {
                return ResourceManager.GetString("PathExpressionsOnly", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Partition key and effective partition key may not both be set..
        /// </summary>
        internal static string PKAndEpkSetTogether {
            get {
                return ResourceManager.GetString("PKAndEpkSetTogether", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A containing range for {0} doesn&apos;t exist in the partition map..
        /// </summary>
        internal static string RangeNotFoundError {
            get {
                return ResourceManager.GetString("RangeNotFoundError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to deserialize response returned by server..
        /// </summary>
        internal static string ServerResponseDeserializationFailure {
            get {
                return ResourceManager.GetString("ServerResponseDeserializationFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The right hand side of string.CompareTo() comparison must be constant &apos;0&apos;.
        /// </summary>
        internal static string StringCompareToInvalidConstant {
            get {
                return ResourceManager.GetString("StringCompareToInvalidConstant", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid operator for string.CompareTo(). Vaid operators are (&apos;==&apos;, &apos;&lt;&apos;, &apos;&lt;=&apos;, &apos;&gt;&apos; or &apos;&gt;=&apos;).
        /// </summary>
        internal static string StringCompareToInvalidOperator {
            get {
                return ResourceManager.GetString("StringCompareToInvalidOperator", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Type check operations can be used in Linq expressions only and are evaluated in Azure CosmosDB server..
        /// </summary>
        internal static string TypeCheckExtensionFunctionsNotImplemented {
            get {
                return ResourceManager.GetString("TypeCheckExtensionFunctionsNotImplemented", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to User-defined function name can not be null or empty..
        /// </summary>
        internal static string UdfNameIsNullOrEmpty {
            get {
                return ResourceManager.GetString("UdfNameIsNullOrEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unary operator &apos;{0}&apos; is not supported..
        /// </summary>
        internal static string UnaryOperatorNotSupported {
            get {
                return ResourceManager.GetString("UnaryOperatorNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unexpected authorization token type &apos;({0})&apos;. Expected &apos;{1}&apos;..
        /// </summary>
        internal static string UnexpectedAuthTokenType {
            get {
                return ResourceManager.GetString("UnexpectedAuthTokenType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unexpected token type: {0}.
        /// </summary>
        internal static string UnexpectedTokenType {
            get {
                return ResourceManager.GetString("UnexpectedTokenType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Consistency, Session, and Triggers are not allowed when AllowBulkExecution is set to true..
        /// </summary>
        internal static string UnsupportedBulkRequestOptions {
            get {
                return ResourceManager.GetString("UnsupportedBulkRequestOptions", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unsupported type {0} for partitionKey..
        /// </summary>
        internal static string UnsupportedPartitionKey {
            get {
                return ResourceManager.GetString("UnsupportedPartitionKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Instantiation of only value types, anonymous types and spatial types are supported..
        /// </summary>
        internal static string ValueAndAnonymousTypesAndGeometryOnly {
            get {
                return ResourceManager.GetString("ValueAndAnonymousTypesAndGeometryOnly", resourceCulture);
            }
        }
    }
}
