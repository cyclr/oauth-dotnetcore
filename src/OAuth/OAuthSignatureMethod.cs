namespace OAuth
{
    /// <summary>
    /// The encryption method to use when hashing a request signature.
    /// </summary>
    public enum OAuthSignatureMethod
    {
        HmacSha1,
        HmacSha256,
        PlainText,
        RsaSha1
    }
}