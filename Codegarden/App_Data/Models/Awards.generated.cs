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
	/// <summary>Awards</summary>
	[PublishedContentModel("awards")]
	public partial class Awards : PublishedContentModel, IHeroMedia, IMetaBase
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "awards";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Awards(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Awards, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Award picker: This picks the awards
		///</summary>
		[ImplementPropertyType("awardPicker")]
		public IEnumerable<IPublishedContent> AwardPicker
		{
			get { return this.GetPropertyValue<IEnumerable<IPublishedContent>>("awardPicker"); }
		}

		///<summary>
		/// Awards Description: This is the description
		///</summary>
		[ImplementPropertyType("awardsDescription")]
		public string AwardsDescription
		{
			get { return this.GetPropertyValue<string>("awardsDescription"); }
		}

		///<summary>
		/// Awards Headline: This is the headline
		///</summary>
		[ImplementPropertyType("awardsHeadline")]
		public string AwardsHeadline
		{
			get { return this.GetPropertyValue<string>("awardsHeadline"); }
		}

		///<summary>
		/// DatesList: This is the list of dates
		///</summary>
		[ImplementPropertyType("datesList")]
		public IEnumerable<string> DatesList
		{
			get { return this.GetPropertyValue<IEnumerable<string>>("datesList"); }
		}

		///<summary>
		/// Join Competition: This is where the macro for the signup form is placed
		///</summary>
		[ImplementPropertyType("joinCompetition")]
		public IHtmlString JoinCompetition
		{
			get { return this.GetPropertyValue<IHtmlString>("joinCompetition"); }
		}

		///<summary>
		/// NotesList: This is a list of notes
		///</summary>
		[ImplementPropertyType("notesList")]
		public IEnumerable<string> NotesList
		{
			get { return this.GetPropertyValue<IEnumerable<string>>("notesList"); }
		}

		///<summary>
		/// RenderJoin: Should Join Competition be shown?
		///</summary>
		[ImplementPropertyType("renderJoin")]
		public bool RenderJoin
		{
			get { return this.GetPropertyValue<bool>("renderJoin"); }
		}

		///<summary>
		/// Rules Headline: This is the headline for the rules section
		///</summary>
		[ImplementPropertyType("rulesHeadline")]
		public string RulesHeadline
		{
			get { return this.GetPropertyValue<string>("rulesHeadline"); }
		}

		///<summary>
		/// RulesList: This is the list of rules
		///</summary>
		[ImplementPropertyType("rulesList")]
		public IEnumerable<string> RulesList
		{
			get { return this.GetPropertyValue<IEnumerable<string>>("rulesList"); }
		}

		///<summary>
		/// Vote Description: This is the description for voting
		///</summary>
		[ImplementPropertyType("voteDescription")]
		public string VoteDescription
		{
			get { return this.GetPropertyValue<string>("voteDescription"); }
		}

		///<summary>
		/// Vote Form: This is a form for voting
		///</summary>
		[ImplementPropertyType("voteForm")]
		public IHtmlString VoteForm
		{
			get { return this.GetPropertyValue<IHtmlString>("voteForm"); }
		}

		///<summary>
		/// Vote Headline: This is the headline for the voting area
		///</summary>
		[ImplementPropertyType("voteHeadline")]
		public string VoteHeadline
		{
			get { return this.GetPropertyValue<string>("voteHeadline"); }
		}

		///<summary>
		/// Hero picker: Choose video or image for header
		///</summary>
		[ImplementPropertyType("heroPicker")]
		public IPublishedContent HeroPicker
		{
			get { return Umbraco.Web.PublishedContentModels.HeroMedia.GetHeroPicker(this); }
		}

		///<summary>
		/// Is video: Click this if a video was chosen
		///</summary>
		[ImplementPropertyType("isVideo")]
		public bool IsVideo
		{
			get { return Umbraco.Web.PublishedContentModels.HeroMedia.GetIsVideo(this); }
		}

		///<summary>
		/// Page title: Page title for banner heading
		///</summary>
		[ImplementPropertyType("pageTitle")]
		public string PageTitle
		{
			get { return Umbraco.Web.PublishedContentModels.HeroMedia.GetPageTitle(this); }
		}

		///<summary>
		/// Meta Description: This is the page description
		///</summary>
		[ImplementPropertyType("metaDescription")]
		public string MetaDescription
		{
			get { return Umbraco.Web.PublishedContentModels.MetaBase.GetMetaDescription(this); }
		}

		///<summary>
		/// Meta Keywords: This is the page keywords
		///</summary>
		[ImplementPropertyType("metaKeywords")]
		public string MetaKeywords
		{
			get { return Umbraco.Web.PublishedContentModels.MetaBase.GetMetaKeywords(this); }
		}

		///<summary>
		/// Meta Ttitle: This is the page title
		///</summary>
		[ImplementPropertyType("metaTtitle")]
		public string MetaTtitle
		{
			get { return Umbraco.Web.PublishedContentModels.MetaBase.GetMetaTtitle(this); }
		}

		///<summary>
		/// Hide in navigation?: Should this page be hidden from the navigation?
		///</summary>
		[ImplementPropertyType("umbracoNaviHide")]
		public bool UmbracoNaviHide
		{
			get { return Umbraco.Web.PublishedContentModels.MetaBase.GetUmbracoNaviHide(this); }
		}
	}
}
