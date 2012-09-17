namespace MVP.PresentationLayer
{
   public interface IView
   {
      void NotifyOfInvalidation(string message);
      void NotifyOfSuccess();
   }
}