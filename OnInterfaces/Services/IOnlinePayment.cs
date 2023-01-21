namespace OnInterfaces.Services
{
    internal interface IOnlinePayment
    {
        public double PaymentFee(double value);
        public double Interest(double value, int months);
    }
}
