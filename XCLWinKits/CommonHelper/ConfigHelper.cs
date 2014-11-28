using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonHelper
{
    public class ConfigHelper
    {
        /// <summary>
        /// 获取当前应用程序根目录（末尾不带\）
        /// </summary>
        /// <returns></returns>
        public static string RootPath
        {
            get { return System.Windows.Forms.Application.StartupPath.TrimEnd('\\'); }
        }

        #region BaseConfig.xml
        /// <summary>
        /// BaseConfig.xml的路径
        /// </summary>
        /// <returns></returns>
        public static string BaseConfigPath
        {
            get{return string.Format(@"{0}\Config\BaseConfig.xml", RootPath);}
        }

        public static string GetBaseConfigStringValue(string assemblyName, string nodeName)
        {
            string str = string.Empty;
            string xpath = string.Format("//Root//{0}//{1}", assemblyName, nodeName);
            System.Xml.XmlNode node = XCLNetTools.XML.XMLHelper.GetXmlNodeByXpath(BaseConfigPath, xpath);
            if (null != node)
            {
                str = node.InnerText;
            }
            return str;
        }

        public static void SetBaseConfigValue(string assemblyName, string nodeName, string innerText)
        {
            string xpath = string.Format("//Root//{0}//{1}", assemblyName, nodeName);
            XCLNetTools.XML.XMLHelper.UpdateXMLNodeInnerText(BaseConfigPath, xpath, innerText);
        }

        public static System.Xml.XmlNodeList GetAssemblyBaseConfigNodeList(string assemblyName)
        {
            string xpath = string.Format("//Root//{0}", assemblyName);
            return XCLNetTools.XML.XMLHelper.GetXmlNodeListByXpath(BaseConfigPath, xpath);
        }
        #endregion

        #region CategoryConfig.xml
        /// <summary>
        /// CategoryConfig.xml的路径
        /// </summary>
        /// <returns></returns>
        public static string CategoryConfigPath
        {
            get{return string.Format(@"{0}\Config\CategoryConfig.xml", RootPath);}
        }

        /// <summary>
        /// 分类
        /// </summary>
        public static List<CommonHelper.Model.CategoryConfig.Category> CategoryList
        {
            get
            {
                List<CommonHelper.Model.CategoryConfig.Category> categoryList = null;
                try
                {
                    Model.CategoryConfig.Category categoryModel = null;
                    List<Model.CategoryConfig.CategoryItem> categoryItemList = null;
                    Model.CategoryConfig.CategoryItem categoryItemModel = null;
                    System.Xml.XmlNodeList nodeList = XCLNetTools.XML.XMLHelper.GetXmlNodeListByXpath(CategoryConfigPath, "//Root//CategoryList//Category");
                    if (null != nodeList && nodeList.Count > 0)
                    {
                        categoryList = new List<Model.CategoryConfig.Category>();
                        for (int i = 0; i < nodeList.Count; i++)
                        {
                            categoryModel = new Model.CategoryConfig.Category();
                            var node = nodeList[i];
                            categoryModel.Name = node.Attributes["Name"].Value.Trim();
                            categoryModel.Sort = Convert.ToInt32(node.Attributes["Sort"].Value.Trim());
                            System.Xml.XmlNodeList categoryItemNodeList = node.SelectNodes("CategoryItemList//CategoryItem");
                            if (null != categoryItemNodeList && categoryItemNodeList.Count > 0)
                            {
                                categoryItemList = new List<Model.CategoryConfig.CategoryItem>();
                                for (int m = 0; m < categoryItemNodeList.Count; m++)
                                {
                                    var categoryItemNode = categoryItemNodeList[m];
                                    categoryItemModel = new Model.CategoryConfig.CategoryItem();
                                    categoryItemModel.AssemblyName =categoryItemNode.Attributes["AssemblyName"].Value.Trim();
                                    categoryItemModel.Name = categoryItemNode.Attributes["Name"].Value.Trim();
                                    categoryItemModel.Sort = Convert.ToInt32(categoryItemNode.Attributes["Sort"].Value.Trim());
                                    categoryItemList.Add(categoryItemModel);
                                }
                                categoryModel.CategoryItemList = categoryItemList.OrderBy(k => k.Sort).ToList();
                            }
                            categoryList.Add(categoryModel);
                        }
                        categoryList = categoryList.OrderBy(k => k.Sort).ToList();
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                return categoryList;
            }
        }

        /// <summary>
        /// 返回程序集的描述，以便将文字描述放在form的标题栏中
        /// </summary>
        public static string GetCategoryNameInfo(string assemblyName)
        {
            string str = string.Empty;
            if (null != CategoryList && CategoryList.Count > 0)
            {
                var model= CategoryList.Where(k => k.CategoryItemList.Exists(m => string.Equals(m.AssemblyName, assemblyName, StringComparison.CurrentCultureIgnoreCase))).First();
                if (null != model)
                {
                    str = string.Format("{0}--{1}", model.Name, model.CategoryItemList.Where(m => string.Equals(m.AssemblyName, assemblyName, StringComparison.CurrentCultureIgnoreCase)).First().Name);
                }
            }
            return str;
        }
        #endregion
    }
}
