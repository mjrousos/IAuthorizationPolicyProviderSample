IAuthorizationPolicyProvider Sample
===================================

This small sample demonstrates how to use `IAuthorizationPolicyProvider` to 
dynamically produce authorization policies.

In the simple example, I create a `MinimumAgePolicyProvider` that 
will produce minimum age policies for any integer age (based on the policy's 
name). This demonstrates a slightly round-about way to allow 'parameterized' 
authorization policies. Since authorization policies are identified by 
name strings, the customer `MinimumAgeAuthorizeAttribute` in the sample 
allows users to specify an age parameter and then embeds it into its 
underlying `AuthorizationAttribute`'s policy name string. The 
`MinimumAgePolicyProvider` dynamically generates the policies needed for use 
with these attributes by pulling the age from the policy name and creating 
necessary authorization requirements.

Other uses of `IAuthorizationPolicyProvider` might be loading policy 
information from some external data source (like a database, for example).
