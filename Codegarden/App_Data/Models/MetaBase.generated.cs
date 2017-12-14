//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.7.99
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder;
using Umbraco.ModelsBuilder.Umbraco;

namespace Umbraco.Web.PublishedContentModels
{
	// Mixin content Type 1200 with alias "metaBase"
	/// <summary>Meta Base</summary>
	public partial interface IMetaBase : IPublishedContent
	{
		/// <summary>Meta Description</summary>
		string MetaDescription { get; }

		/// <summary>Meta Keywords</summary>
		string MetaKeywords { get; }

		/// <summary>Meta Ttitle</summary>
		string MetaTitle { get; }

		/// <summary>Hide in navigation?</summary>
		bool UmbracoNaviHide { get; }
	}

	/// <summary>Meta Base</summary>
	[PublishedContentModel("metaBase")]
	public partial class MetaBase : PublishedContentModel, IMetaBase
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "metaBase";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public MetaBase(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<MetaBase, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Meta Description: This is the page description
		///</summary>
		[ImplementPropertyType("metaDescription")]
		public string MetaDescription
		{
			get { return GetMetaDescription(this); }
		}

		/// <summary>Static getter for Meta Description</summary>
		public static string GetMetaDescription(IMetaBase that) { return that.GetPropertyValue<string>("metaDescription"); }

		///<summary>
		/// Meta Keywords: This is the page keywords
		///</summary>
		[ImplementPropertyType("metaKeywords")]
		public string MetaKeywords
		{
			get { return GetMetaKeywords(this); }
		}

		/// <summary>Static getter for Meta Keywords</summary>
		public static string GetMetaKeywords(IMetaBase that) { return that.GetPropertyValue<string>("metaKeywords"); }

		///<summary>
		/// Meta Ttitle: This is the page title
		///</summary>
		[ImplementPropertyType("metaTitle")]
		public string MetaTitle
		{
			get { return GetMetaTitle(this); }
		}

		/// <summary>Static getter for Meta Ttitle</summary>
		public static string GetMetaTitle(IMetaBase that) { return that.GetPropertyValue<string>("metaTitle"); }

		///<summary>
		/// Hide in navigation?: Should this page be hidden from the navigation?
		///</summary>
		[ImplementPropertyType("umbracoNaviHide")]
		public bool UmbracoNaviHide
		{
			get { return GetUmbracoNaviHide(this); }
		}

		/// <summary>Static getter for Hide in navigation?</summary>
		public static bool GetUmbracoNaviHide(IMetaBase that) { return that.GetPropertyValue<bool>("umbracoNaviHide"); }
	}
}
