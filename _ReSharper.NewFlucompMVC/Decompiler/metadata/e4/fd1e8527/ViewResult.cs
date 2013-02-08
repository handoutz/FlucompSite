// Type: System.Web.Mvc.ViewResult
// Assembly: System.Web.Mvc, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// Assembly location: C:\Program Files (x86)\Microsoft ASP.NET\ASP.NET MVC 3\Assemblies\System.Web.Mvc.dll

namespace System.Web.Mvc
{
  /// <summary>
  /// Represents a class that is used to render a view by using an <see cref="T:System.Web.Mvc.IView"/> instance that is returned by an <see cref="T:System.Web.Mvc.IViewEngine"/> object.
  /// </summary>
  public class ViewResult : ViewResultBase
  {
    /// <summary>
    /// Searches the registered view engines and returns the object that is used to render the view.
    /// </summary>
    /// 
    /// <returns>
    /// The object that is used to render the view.
    /// </returns>
    /// <param name="context">The controller context.</param><exception cref="T:System.InvalidOperationException">An error occurred while the method was searching for the view.</exception>
    protected override ViewEngineResult FindView(ControllerContext context);
    /// <summary>
    /// Gets the name of the master view (such as a master page or template) to use when the view is rendered.
    /// </summary>
    /// 
    /// <returns>
    /// The name of the master view.
    /// </returns>
    public string MasterName { get; set; }
  }
}
