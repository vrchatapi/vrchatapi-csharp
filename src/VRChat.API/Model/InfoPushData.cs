

#pragma warning disable CS0612
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using FileParameter = VRChat.API.Client.FileParameter;
using OpenAPIDateConverter = VRChat.API.Client.OpenAPIDateConverter;

namespace VRChat.API.Model
{
    /// <summary>
    /// InfoPushData
    /// </summary>
    [DataContract(Name = "InfoPushData")]
    public partial class InfoPushData : IEquatable<InfoPushData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InfoPushData" /> class.
        /// </summary>
        /// <param name="article">article.</param>
        /// <param name="authorName">authorName.</param>
        /// <param name="avatarId">avatarId.</param>
        /// <param name="bannerImageUrl">bannerImageUrl.</param>
        /// <param name="categories">categories.</param>
        /// <param name="category">category.</param>
        /// <param name="contentList">contentList.</param>
        /// <param name="description">description.</param>
        /// <param name="disclaimerText">disclaimerText.</param>
        /// <param name="domainList">domainList.</param>
        /// <param name="featuredAvatarCategoryId">featuredAvatarCategoryId.</param>
        /// <param name="finalName">finalName.</param>
        /// <param name="iconImageUrl">iconImageUrl.</param>
        /// <param name="imageUrl">imageUrl.</param>
        /// <param name="ipsQuery">ipsQuery.</param>
        /// <param name="isNew">isNew.</param>
        /// <param name="listingIds">listingIds.</param>
        /// <param name="name">name.</param>
        /// <param name="onPressed">onPressed.</param>
        /// <param name="overrideName">overrideName.</param>
        /// <param name="rows">Number of rows to render..</param>
        /// <param name="search">search.</param>
        /// <param name="shortName">shortName.</param>
        /// <param name="template">template.</param>
        /// <param name="thumbnailImageUrl">thumbnailImageUrl.</param>
        /// <param name="tooltipDescription">tooltipDescription.</param>
        /// <param name="varVersion">varVersion.</param>
        /// <param name="weight">weight.</param>
        /// <param name="worldTag">worldTag.</param>
        public InfoPushData(InfoPushDataArticle article = default, string authorName = default, string avatarId = default, string bannerImageUrl = default, List<InfoPushDataCategory> categories = default, string category = default, DynamicContentRow contentList = default, string description = default, string disclaimerText = default, List<InfoPushDataDomainListInner> domainList = default, string featuredAvatarCategoryId = default, string finalName = default, string iconImageUrl = default, string imageUrl = default, InfoPushIpsQuery ipsQuery = default, bool isNew = default, List<string> listingIds = default, string name = default, InfoPushDataClickable onPressed = default, Object overrideName = default, int? rows = default, InfoPushDataSearch search = default, string shortName = default, string template = default, string thumbnailImageUrl = default, string tooltipDescription = default, string varVersion = default, int weight = default, string worldTag = default)
        {
            this.Article = article;
            this.AuthorName = authorName;
            this.AvatarId = avatarId;
            this.BannerImageUrl = bannerImageUrl;
            this.Categories = categories;
            this.Category = category;
            this.ContentList = contentList;
            this.Description = description;
            this.DisclaimerText = disclaimerText;
            this.DomainList = domainList;
            this.FeaturedAvatarCategoryId = featuredAvatarCategoryId;
            this.FinalName = finalName;
            this.IconImageUrl = iconImageUrl;
            this.ImageUrl = imageUrl;
            this.IpsQuery = ipsQuery;
            this.IsNew = isNew;
            this.ListingIds = listingIds;
            this.Name = name;
            this.OnPressed = onPressed;
            this.OverrideName = overrideName;
            this.Rows = rows;
            this.Search = search;
            this.ShortName = shortName;
            this.Template = template;
            this.ThumbnailImageUrl = thumbnailImageUrl;
            this.TooltipDescription = tooltipDescription;
            this.VarVersion = varVersion;
            this.Weight = weight;
            this.WorldTag = worldTag;
        }

        /// <summary>
        /// Gets or Sets Article
        /// </summary>
        [DataMember(Name = "article", EmitDefaultValue = false)]
        public InfoPushDataArticle Article { get; set; }

        /// <summary>
        /// Gets or Sets AuthorName
        /// </summary>
        [DataMember(Name = "authorName", EmitDefaultValue = false)]
        public string AuthorName { get; set; }

        /// <summary>
        /// Gets or Sets AvatarId
        /// </summary>
        /*
        <example>avtr_912d66a4-4714-43b8-8407-7de2cafbf55b</example>
        */
        [DataMember(Name = "avatarId", EmitDefaultValue = false)]
        public string AvatarId { get; set; }

        /// <summary>
        /// Gets or Sets BannerImageUrl
        /// </summary>
        [DataMember(Name = "bannerImageUrl", EmitDefaultValue = false)]
        public string BannerImageUrl { get; set; }

        /// <summary>
        /// Gets or Sets Categories
        /// </summary>
        [DataMember(Name = "categories", EmitDefaultValue = false)]
        public List<InfoPushDataCategory> Categories { get; set; }

        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name = "category", EmitDefaultValue = false)]
        public string Category { get; set; }

        /// <summary>
        /// Gets or Sets ContentList
        /// </summary>
        [DataMember(Name = "contentList", EmitDefaultValue = false)]
        public DynamicContentRow ContentList { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets DisclaimerText
        /// </summary>
        [DataMember(Name = "disclaimerText", EmitDefaultValue = false)]
        public string DisclaimerText { get; set; }

        /// <summary>
        /// Gets or Sets DomainList
        /// </summary>
        [DataMember(Name = "domainList", EmitDefaultValue = false)]
        public List<InfoPushDataDomainListInner> DomainList { get; set; }

        /// <summary>
        /// Gets or Sets FeaturedAvatarCategoryId
        /// </summary>
        [DataMember(Name = "featuredAvatarCategoryId", EmitDefaultValue = false)]
        public string FeaturedAvatarCategoryId { get; set; }

        /// <summary>
        /// Gets or Sets FinalName
        /// </summary>
        [DataMember(Name = "finalName", EmitDefaultValue = false)]
        public string FinalName { get; set; }

        /// <summary>
        /// Gets or Sets IconImageUrl
        /// </summary>
        [DataMember(Name = "iconImageUrl", EmitDefaultValue = false)]
        public string IconImageUrl { get; set; }

        /// <summary>
        /// Gets or Sets ImageUrl
        /// </summary>
        [DataMember(Name = "imageUrl", EmitDefaultValue = true)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// Gets or Sets IpsQuery
        /// </summary>
        [DataMember(Name = "ipsQuery", EmitDefaultValue = false)]
        public InfoPushIpsQuery IpsQuery { get; set; }

        /// <summary>
        /// Gets or Sets IsNew
        /// </summary>
        [DataMember(Name = "isNew", EmitDefaultValue = true)]
        public bool IsNew { get; set; }

        /// <summary>
        /// Gets or Sets ListingIds
        /// </summary>
        [DataMember(Name = "listingIds", EmitDefaultValue = false)]
        public List<string> ListingIds { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets OnPressed
        /// </summary>
        [DataMember(Name = "onPressed", EmitDefaultValue = false)]
        public InfoPushDataClickable OnPressed { get; set; }

        /// <summary>
        /// Gets or Sets OverrideName
        /// </summary>
        [DataMember(Name = "overrideName", EmitDefaultValue = true)]
        public Object OverrideName { get; set; }

        /// <summary>
        /// Number of rows to render.
        /// </summary>
        /// <value>Number of rows to render.</value>
        [DataMember(Name = "rows", EmitDefaultValue = true)]
        public int? Rows { get; set; }

        /// <summary>
        /// Gets or Sets Search
        /// </summary>
        [DataMember(Name = "search", EmitDefaultValue = false)]
        public InfoPushDataSearch Search { get; set; }

        /// <summary>
        /// Gets or Sets ShortName
        /// </summary>
        [DataMember(Name = "shortName", EmitDefaultValue = true)]
        public string ShortName { get; set; }

        /// <summary>
        /// Gets or Sets Template
        /// </summary>
        [DataMember(Name = "template", EmitDefaultValue = false)]
        public string Template { get; set; }

        /// <summary>
        /// Gets or Sets ThumbnailImageUrl
        /// </summary>
        [DataMember(Name = "thumbnailImageUrl", EmitDefaultValue = true)]
        public string ThumbnailImageUrl { get; set; }

        /// <summary>
        /// Gets or Sets TooltipDescription
        /// </summary>
        [DataMember(Name = "tooltipDescription", EmitDefaultValue = false)]
        public string TooltipDescription { get; set; }

        /// <summary>
        /// Gets or Sets VarVersion
        /// </summary>
        /*
        <example>2021.3.4</example>
        */
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public string VarVersion { get; set; }

        /// <summary>
        /// Gets or Sets Weight
        /// </summary>
        [DataMember(Name = "weight", EmitDefaultValue = false)]
        public int Weight { get; set; }

        /// <summary>
        /// Gets or Sets WorldTag
        /// </summary>
        [DataMember(Name = "worldTag", EmitDefaultValue = false)]
        public string WorldTag { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InfoPushData {\n");
            sb.Append("  Article: ").Append(Article).Append("\n");
            sb.Append("  AuthorName: ").Append(AuthorName).Append("\n");
            sb.Append("  AvatarId: ").Append(AvatarId).Append("\n");
            sb.Append("  BannerImageUrl: ").Append(BannerImageUrl).Append("\n");
            sb.Append("  Categories: ").Append(Categories).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  ContentList: ").Append(ContentList).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DisclaimerText: ").Append(DisclaimerText).Append("\n");
            sb.Append("  DomainList: ").Append(DomainList).Append("\n");
            sb.Append("  FeaturedAvatarCategoryId: ").Append(FeaturedAvatarCategoryId).Append("\n");
            sb.Append("  FinalName: ").Append(FinalName).Append("\n");
            sb.Append("  IconImageUrl: ").Append(IconImageUrl).Append("\n");
            sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
            sb.Append("  IpsQuery: ").Append(IpsQuery).Append("\n");
            sb.Append("  IsNew: ").Append(IsNew).Append("\n");
            sb.Append("  ListingIds: ").Append(ListingIds).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  OnPressed: ").Append(OnPressed).Append("\n");
            sb.Append("  OverrideName: ").Append(OverrideName).Append("\n");
            sb.Append("  Rows: ").Append(Rows).Append("\n");
            sb.Append("  Search: ").Append(Search).Append("\n");
            sb.Append("  ShortName: ").Append(ShortName).Append("\n");
            sb.Append("  Template: ").Append(Template).Append("\n");
            sb.Append("  ThumbnailImageUrl: ").Append(ThumbnailImageUrl).Append("\n");
            sb.Append("  TooltipDescription: ").Append(TooltipDescription).Append("\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
            sb.Append("  Weight: ").Append(Weight).Append("\n");
            sb.Append("  WorldTag: ").Append(WorldTag).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as InfoPushData);
        }

        /// <summary>
        /// Returns true if InfoPushData instances are equal
        /// </summary>
        /// <param name="input">Instance of InfoPushData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InfoPushData input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Article == input.Article ||
                    (this.Article != null &&
                    this.Article.Equals(input.Article))
                ) && 
                (
                    this.AuthorName == input.AuthorName ||
                    (this.AuthorName != null &&
                    this.AuthorName.Equals(input.AuthorName))
                ) && 
                (
                    this.AvatarId == input.AvatarId ||
                    (this.AvatarId != null &&
                    this.AvatarId.Equals(input.AvatarId))
                ) && 
                (
                    this.BannerImageUrl == input.BannerImageUrl ||
                    (this.BannerImageUrl != null &&
                    this.BannerImageUrl.Equals(input.BannerImageUrl))
                ) && 
                (
                    this.Categories == input.Categories ||
                    this.Categories != null &&
                    input.Categories != null &&
                    this.Categories.SequenceEqual(input.Categories)
                ) && 
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) && 
                (
                    this.ContentList == input.ContentList ||
                    (this.ContentList != null &&
                    this.ContentList.Equals(input.ContentList))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.DisclaimerText == input.DisclaimerText ||
                    (this.DisclaimerText != null &&
                    this.DisclaimerText.Equals(input.DisclaimerText))
                ) && 
                (
                    this.DomainList == input.DomainList ||
                    this.DomainList != null &&
                    input.DomainList != null &&
                    this.DomainList.SequenceEqual(input.DomainList)
                ) && 
                (
                    this.FeaturedAvatarCategoryId == input.FeaturedAvatarCategoryId ||
                    (this.FeaturedAvatarCategoryId != null &&
                    this.FeaturedAvatarCategoryId.Equals(input.FeaturedAvatarCategoryId))
                ) && 
                (
                    this.FinalName == input.FinalName ||
                    (this.FinalName != null &&
                    this.FinalName.Equals(input.FinalName))
                ) && 
                (
                    this.IconImageUrl == input.IconImageUrl ||
                    (this.IconImageUrl != null &&
                    this.IconImageUrl.Equals(input.IconImageUrl))
                ) && 
                (
                    this.ImageUrl == input.ImageUrl ||
                    (this.ImageUrl != null &&
                    this.ImageUrl.Equals(input.ImageUrl))
                ) && 
                (
                    this.IpsQuery == input.IpsQuery ||
                    (this.IpsQuery != null &&
                    this.IpsQuery.Equals(input.IpsQuery))
                ) && 
                (
                    this.IsNew == input.IsNew ||
                    this.IsNew.Equals(input.IsNew)
                ) && 
                (
                    this.ListingIds == input.ListingIds ||
                    this.ListingIds != null &&
                    input.ListingIds != null &&
                    this.ListingIds.SequenceEqual(input.ListingIds)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.OnPressed == input.OnPressed ||
                    (this.OnPressed != null &&
                    this.OnPressed.Equals(input.OnPressed))
                ) && 
                (
                    this.OverrideName == input.OverrideName ||
                    (this.OverrideName != null &&
                    this.OverrideName.Equals(input.OverrideName))
                ) && 
                (
                    this.Rows == input.Rows ||
                    (this.Rows != null &&
                    this.Rows.Equals(input.Rows))
                ) && 
                (
                    this.Search == input.Search ||
                    (this.Search != null &&
                    this.Search.Equals(input.Search))
                ) && 
                (
                    this.ShortName == input.ShortName ||
                    (this.ShortName != null &&
                    this.ShortName.Equals(input.ShortName))
                ) && 
                (
                    this.Template == input.Template ||
                    (this.Template != null &&
                    this.Template.Equals(input.Template))
                ) && 
                (
                    this.ThumbnailImageUrl == input.ThumbnailImageUrl ||
                    (this.ThumbnailImageUrl != null &&
                    this.ThumbnailImageUrl.Equals(input.ThumbnailImageUrl))
                ) && 
                (
                    this.TooltipDescription == input.TooltipDescription ||
                    (this.TooltipDescription != null &&
                    this.TooltipDescription.Equals(input.TooltipDescription))
                ) && 
                (
                    this.VarVersion == input.VarVersion ||
                    (this.VarVersion != null &&
                    this.VarVersion.Equals(input.VarVersion))
                ) && 
                (
                    this.Weight == input.Weight ||
                    this.Weight.Equals(input.Weight)
                ) && 
                (
                    this.WorldTag == input.WorldTag ||
                    (this.WorldTag != null &&
                    this.WorldTag.Equals(input.WorldTag))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Article != null)
                {
                    hashCode = (hashCode * 59) + this.Article.GetHashCode();
                }
                if (this.AuthorName != null)
                {
                    hashCode = (hashCode * 59) + this.AuthorName.GetHashCode();
                }
                if (this.AvatarId != null)
                {
                    hashCode = (hashCode * 59) + this.AvatarId.GetHashCode();
                }
                if (this.BannerImageUrl != null)
                {
                    hashCode = (hashCode * 59) + this.BannerImageUrl.GetHashCode();
                }
                if (this.Categories != null)
                {
                    hashCode = (hashCode * 59) + this.Categories.GetHashCode();
                }
                if (this.Category != null)
                {
                    hashCode = (hashCode * 59) + this.Category.GetHashCode();
                }
                if (this.ContentList != null)
                {
                    hashCode = (hashCode * 59) + this.ContentList.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.DisclaimerText != null)
                {
                    hashCode = (hashCode * 59) + this.DisclaimerText.GetHashCode();
                }
                if (this.DomainList != null)
                {
                    hashCode = (hashCode * 59) + this.DomainList.GetHashCode();
                }
                if (this.FeaturedAvatarCategoryId != null)
                {
                    hashCode = (hashCode * 59) + this.FeaturedAvatarCategoryId.GetHashCode();
                }
                if (this.FinalName != null)
                {
                    hashCode = (hashCode * 59) + this.FinalName.GetHashCode();
                }
                if (this.IconImageUrl != null)
                {
                    hashCode = (hashCode * 59) + this.IconImageUrl.GetHashCode();
                }
                if (this.ImageUrl != null)
                {
                    hashCode = (hashCode * 59) + this.ImageUrl.GetHashCode();
                }
                if (this.IpsQuery != null)
                {
                    hashCode = (hashCode * 59) + this.IpsQuery.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsNew.GetHashCode();
                if (this.ListingIds != null)
                {
                    hashCode = (hashCode * 59) + this.ListingIds.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.OnPressed != null)
                {
                    hashCode = (hashCode * 59) + this.OnPressed.GetHashCode();
                }
                if (this.OverrideName != null)
                {
                    hashCode = (hashCode * 59) + this.OverrideName.GetHashCode();
                }
                if (this.Rows != null)
                {
                    hashCode = (hashCode * 59) + this.Rows.GetHashCode();
                }
                if (this.Search != null)
                {
                    hashCode = (hashCode * 59) + this.Search.GetHashCode();
                }
                if (this.ShortName != null)
                {
                    hashCode = (hashCode * 59) + this.ShortName.GetHashCode();
                }
                if (this.Template != null)
                {
                    hashCode = (hashCode * 59) + this.Template.GetHashCode();
                }
                if (this.ThumbnailImageUrl != null)
                {
                    hashCode = (hashCode * 59) + this.ThumbnailImageUrl.GetHashCode();
                }
                if (this.TooltipDescription != null)
                {
                    hashCode = (hashCode * 59) + this.TooltipDescription.GetHashCode();
                }
                if (this.VarVersion != null)
                {
                    hashCode = (hashCode * 59) + this.VarVersion.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Weight.GetHashCode();
                if (this.WorldTag != null)
                {
                    hashCode = (hashCode * 59) + this.WorldTag.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // VarVersion (string) minLength
            if (this.VarVersion != null && this.VarVersion.Length < 1)
            {
                yield return new ValidationResult("Invalid value for VarVersion, length must be greater than 1.", new [] { "VarVersion" });
            }

            yield break;
        }
    }

}
