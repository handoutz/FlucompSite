// Type: System.Web.Mvc.WebViewPage`1
// Assembly: System.Web.Mvc, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// Assembly location: C:\Program Files (x86)\Microsoft ASP.NET\ASP.NET MVC 3\Assemblies\System.Web.Mvc.dll

namespace System.Web.Mvc
{
  /// <summary>
  /// Represents the properties and methods that are needed in order to render a view that uses ASP.NET Razor syntax.
  /// </summary>
  /// <typeparam name="TModel">The type of the view data model.</typeparam>
  public abstract class WebViewPage<TModel> : WebViewPage
  {
    /// <summary>
    /// Initializes the <see cref="T:System.Web.Mvc.AjaxHelper"/>, <see cref="T:System.Web.Mvc.HtmlHelper"/>, and <see cref="T:System.Web.Mvc.UrlHelper"/> classes.
    /// </summary>
    public override void InitHelpers();
    /// <summary>
    /// Sets the view data.
    /// </summary>
    /// <param name="viewData">The view data.</param>
    protected override void SetViewData(ViewDataDictionary viewData);
    /// <summary>
    /// Gets or sets the <see cref="T:System.Web.Mvc.AjaxHelper"/> object that is used to render HTML markup using Ajax.
    /// </summary>
    /// 
    /// <returns>
    /// The <see cref="T:System.Web.Mvc.AjaxHelper"/> object that is used to render HTML markup using Ajax.
    /// </returns>
    public new AjaxHelper<TModel> Ajax { get; set; }
    /// <summary>
    /// Gets or sets the <see cref="T:System.Web.Mvc.HtmlHelper"/> object that is used to render HTML elements.
    /// </summary>
    /// 
    /// <returns>
    /// The <see cref="T:System.Web.Mvc.HtmlHelper"/> object that is used to render HTML elements.
    /// </returns>
    public new HtmlHelper<TModel> Html { get; set; }
    /// <summary>
    /// Gets the Model property of the associated <see cref="T:System.Web.Mvc.ViewDataDictionary"/> object.
    /// </summary>
    /// 
    /// <returns>
    /// The Model property of the associated <see cref="T:System.Web.Mvc.ViewDataDictionary"/> object.
    /// </returns>
    public new TModel Model { get; }
    /// <summary>
    /// Gets or sets a dictionary that contains data to pass between the controller and the view.
    /// </summary>
    /// 
    /// <returns>
    /// A dictionary that contains data to pass between the controller and the view.
    /// </returns>
    public new ViewDataDictionary<TModel> ViewData { get; set; }
  }
}
