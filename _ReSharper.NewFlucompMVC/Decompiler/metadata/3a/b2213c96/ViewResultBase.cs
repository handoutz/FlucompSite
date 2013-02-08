// Type: System.Web.Mvc.ViewResultBase
// Assembly: System.Web.Mvc, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// Assembly location: C:\Program Files (x86)\Microsoft ASP.NET\ASP.NET MVC 3\Assemblies\System.Web.Mvc.dll

namespace System.Web.Mvc
{
  /// <summary>
  /// Represents a base class that is used to provide the model to the view and then render the view to the response.
  /// </summary>
  public abstract class ViewResultBase : ActionResult
  {
    /// <summary>
    /// When called by the action invoker, renders the view to the response.
    /// </summary>
    /// <param name="context">The context that the result is executed in.</param><exception cref="T:System.ArgumentNullException">The <paramref name="context"/> parameter is null.</exception>
    public override void ExecuteResult(ControllerContext context);
    /// <summary>
    /// Returns the <see cref="T:System.Web.Mvc.ViewEngineResult"/> object that is used to render the view.
    /// </summary>
    /// 
    /// <returns>
    /// The view engine.
    /// </returns>
    /// <param name="context">The context.</param>
    protected abstract ViewEngineResult FindView(ControllerContext context);
    /// <summary>
    /// Gets the view data model.
    /// </summary>
    /// 
    /// <returns>
    /// The view data model.
    /// </returns>
    public object Model { get; }
    /// <summary>
    /// Gets or sets the <see cref="T:System.Web.Mvc.TempDataDictionary"/> object for this result.
    /// </summary>
    /// 
    /// <returns>
    /// The temporary data.
    /// </returns>
    public TempDataDictionary TempData { get; set; }
    /// <summary>
    /// Gets or sets the <see cref="T:System.Web.Mvc.IView"/> object that is rendered to the response.
    /// </summary>
    /// 
    /// <returns>
    /// The view.
    /// </returns>
    public IView View { get; set; }
    /// <summary>
    /// Gets the view bag.
    /// </summary>
    /// 
    /// <returns>
    /// The view bag.
    /// </returns>
    public dynamic ViewBag { get; }
    /// <summary>
    /// Gets or sets the view data <see cref="T:System.Web.Mvc.ViewDataDictionary"/> object for this result.
    /// </summary>
    /// 
    /// <returns>
    /// The view data.
    /// </returns>
    public ViewDataDictionary ViewData { get; set; }
    /// <summary>
    /// Gets or sets the collection of view engines that are associated with this result.
    /// </summary>
    /// 
    /// <returns>
    /// The collection of view engines.
    /// </returns>
    public ViewEngineCollection ViewEngineCollection { get; set; }
    /// <summary>
    /// Gets or sets the name of the view to render.
    /// </summary>
    /// 
    /// <returns>
    /// The name of the view.
    /// </returns>
    public string ViewName { get; set; }
  }
}
