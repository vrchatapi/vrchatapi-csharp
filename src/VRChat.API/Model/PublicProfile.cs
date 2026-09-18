

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
    /// PublicProfile
    /// </summary>
    [DataContract(Name = "PublicProfile")]
    public partial class PublicProfile : IEquatable<PublicProfile>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets AgeVerificationStatus
        /// </summary>
        [DataMember(Name = "ageVerificationStatus", EmitDefaultValue = false)]
        public AgeVerificationStatus? AgeVerificationStatus { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public UserStatus? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PublicProfile" /> class.
        /// </summary>
        /// <param name="ageVerificationStatus">ageVerificationStatus.</param>
        /// <param name="ageVerified">&#x60;true&#x60; if, user is age verified (not 18+)..</param>
        /// <param name="backgroundGradientBottom">Six hexadecimal digits, without a leading &#x60;#&#x60;. May be empty..</param>
        /// <param name="backgroundGradientTop">Six hexadecimal digits, without a leading &#x60;#&#x60;. May be empty..</param>
        /// <param name="backgroundTemplateId">backgroundTemplateId.</param>
        /// <param name="backgroundTextureId">backgroundTextureId.</param>
        /// <param name="backgroundType">backgroundType.</param>
        /// <param name="badges">badges.</param>
        /// <param name="bannerColor">Six hexadecimal digits, without a leading &#x60;#&#x60;. May be empty..</param>
        /// <param name="bannerCustomUrl">bannerCustomUrl.</param>
        /// <param name="bannerType">bannerType.</param>
        /// <param name="bannerUrl">bannerUrl.</param>
        /// <param name="bio">bio.</param>
        /// <param name="bioLinks">bioLinks.</param>
        /// <param name="currentAvatar">currentAvatar.</param>
        /// <param name="currentAvatarAuthorName">currentAvatarAuthorName.</param>
        /// <param name="currentAvatarImageUrl">When profilePicOverride is not empty, use it instead..</param>
        /// <param name="currentAvatarName">currentAvatarName.</param>
        /// <param name="currentAvatarTags">currentAvatarTags.</param>
        /// <param name="currentAvatarThumbnailImageUrl">When profilePicOverride is not empty, use it instead..</param>
        /// <param name="displayName">displayName.</param>
        /// <param name="groups">groups.</param>
        /// <param name="hasVrcPlus">hasVrcPlus.</param>
        /// <param name="iconFrame">iconFrame.</param>
        /// <param name="iconType">iconType.</param>
        /// <param name="iconUrl">iconUrl.</param>
        /// <param name="id">A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed..</param>
        /// <param name="isEconomyCreator">isEconomyCreator.</param>
        /// <param name="languages">languages.</param>
        /// <param name="nameplateEffect">nameplateEffect.</param>
        /// <param name="profileEffect">profileEffect.</param>
        /// <param name="pronouns">pronouns.</param>
        /// <param name="publicWorlds">publicWorlds.</param>
        /// <param name="representedGroup">representedGroup.</param>
        /// <param name="status">status.</param>
        /// <param name="statusDescription">statusDescription.</param>
        /// <param name="themeButtonColor">Six hexadecimal digits, without a leading &#x60;#&#x60;. May be empty..</param>
        /// <param name="themeIconColor">Six hexadecimal digits, without a leading &#x60;#&#x60;. May be empty..</param>
        /// <param name="themeId">themeId.</param>
        /// <param name="themeSubtextColor">Six hexadecimal digits, without a leading &#x60;#&#x60;. May be empty..</param>
        /// <param name="themes">themes.</param>
        /// <param name="totalPublicWorldsCount">totalPublicWorldsCount.</param>
        /// <param name="trustTags">trustTags.</param>
        /// <param name="userIcon">userIcon.</param>
        /// <param name="worldFavoriteLists">The owner&#39;s public world favorite groups..</param>
        public PublicProfile(AgeVerificationStatus? ageVerificationStatus = default, bool ageVerified = default, string backgroundGradientBottom = default, string backgroundGradientTop = default, string backgroundTemplateId = default, string backgroundTextureId = default, string backgroundType = default, List<Badge> badges = default, string bannerColor = default, string bannerCustomUrl = default, string bannerType = default, string bannerUrl = default, string bio = default, List<string> bioLinks = default, string currentAvatar = default, string currentAvatarAuthorName = default, string currentAvatarImageUrl = default, string currentAvatarName = default, List<string> currentAvatarTags = default, string currentAvatarThumbnailImageUrl = default, string displayName = default, ProfileGroups groups = default, bool hasVrcPlus = default, string iconFrame = default, string iconType = default, string iconUrl = default, string id = default, bool isEconomyCreator = default, List<string> languages = default, string nameplateEffect = default, string profileEffect = default, string pronouns = default, List<LimitedWorld> publicWorlds = default, ProfileRepresentedGroup representedGroup = default, UserStatus? status = default, string statusDescription = default, string themeButtonColor = default, string themeIconColor = default, string themeId = default, string themeSubtextColor = default, List<Object> themes = default, int totalPublicWorldsCount = default, List<string> trustTags = default, string userIcon = default, List<WorldFavoriteList> worldFavoriteLists = default)
        {
            this.AgeVerificationStatus = ageVerificationStatus;
            this.AgeVerified = ageVerified;
            this.BackgroundGradientBottom = backgroundGradientBottom;
            this.BackgroundGradientTop = backgroundGradientTop;
            this.BackgroundTemplateId = backgroundTemplateId;
            this.BackgroundTextureId = backgroundTextureId;
            this.BackgroundType = backgroundType;
            this.Badges = badges;
            this.BannerColor = bannerColor;
            this.BannerCustomUrl = bannerCustomUrl;
            this.BannerType = bannerType;
            this.BannerUrl = bannerUrl;
            this.Bio = bio;
            this.BioLinks = bioLinks;
            this.CurrentAvatar = currentAvatar;
            this.CurrentAvatarAuthorName = currentAvatarAuthorName;
            this.CurrentAvatarImageUrl = currentAvatarImageUrl;
            this.CurrentAvatarName = currentAvatarName;
            this.CurrentAvatarTags = currentAvatarTags;
            this.CurrentAvatarThumbnailImageUrl = currentAvatarThumbnailImageUrl;
            this.DisplayName = displayName;
            this.Groups = groups;
            this.HasVrcPlus = hasVrcPlus;
            this.IconFrame = iconFrame;
            this.IconType = iconType;
            this.IconUrl = iconUrl;
            this.Id = id;
            this.IsEconomyCreator = isEconomyCreator;
            this.Languages = languages;
            this.NameplateEffect = nameplateEffect;
            this.ProfileEffect = profileEffect;
            this.Pronouns = pronouns;
            this.PublicWorlds = publicWorlds;
            this.RepresentedGroup = representedGroup;
            this.Status = status;
            this.StatusDescription = statusDescription;
            this.ThemeButtonColor = themeButtonColor;
            this.ThemeIconColor = themeIconColor;
            this.ThemeId = themeId;
            this.ThemeSubtextColor = themeSubtextColor;
            this.Themes = themes;
            this.TotalPublicWorldsCount = totalPublicWorldsCount;
            this.TrustTags = trustTags;
            this.UserIcon = userIcon;
            this.WorldFavoriteLists = worldFavoriteLists;
        }

        /// <summary>
        /// &#x60;true&#x60; if, user is age verified (not 18+).
        /// </summary>
        /// <value>&#x60;true&#x60; if, user is age verified (not 18+).</value>
        [DataMember(Name = "ageVerified", EmitDefaultValue = true)]
        public bool AgeVerified { get; set; }

        /// <summary>
        /// Six hexadecimal digits, without a leading &#x60;#&#x60;. May be empty.
        /// </summary>
        /// <value>Six hexadecimal digits, without a leading &#x60;#&#x60;. May be empty.</value>
        /*
        <example>3cc92c</example>
        */
        [DataMember(Name = "backgroundGradientBottom", EmitDefaultValue = false)]
        public string BackgroundGradientBottom { get; set; }

        /// <summary>
        /// Six hexadecimal digits, without a leading &#x60;#&#x60;. May be empty.
        /// </summary>
        /// <value>Six hexadecimal digits, without a leading &#x60;#&#x60;. May be empty.</value>
        /*
        <example>3cc92c</example>
        */
        [DataMember(Name = "backgroundGradientTop", EmitDefaultValue = false)]
        public string BackgroundGradientTop { get; set; }

        /// <summary>
        /// Gets or Sets BackgroundTemplateId
        /// </summary>
        [DataMember(Name = "backgroundTemplateId", EmitDefaultValue = false)]
        public string BackgroundTemplateId { get; set; }

        /// <summary>
        /// Gets or Sets BackgroundTextureId
        /// </summary>
        [DataMember(Name = "backgroundTextureId", EmitDefaultValue = false)]
        public string BackgroundTextureId { get; set; }

        /// <summary>
        /// Gets or Sets BackgroundType
        /// </summary>
        [DataMember(Name = "backgroundType", EmitDefaultValue = false)]
        public string BackgroundType { get; set; }

        /// <summary>
        /// Gets or Sets Badges
        /// </summary>
        [DataMember(Name = "badges", EmitDefaultValue = false)]
        public List<Badge> Badges { get; set; }

        /// <summary>
        /// Six hexadecimal digits, without a leading &#x60;#&#x60;. May be empty.
        /// </summary>
        /// <value>Six hexadecimal digits, without a leading &#x60;#&#x60;. May be empty.</value>
        /*
        <example>3cc92c</example>
        */
        [DataMember(Name = "bannerColor", EmitDefaultValue = false)]
        public string BannerColor { get; set; }

        /// <summary>
        /// Gets or Sets BannerCustomUrl
        /// </summary>
        [DataMember(Name = "bannerCustomUrl", EmitDefaultValue = false)]
        public string BannerCustomUrl { get; set; }

        /// <summary>
        /// Gets or Sets BannerType
        /// </summary>
        [DataMember(Name = "bannerType", EmitDefaultValue = false)]
        public string BannerType { get; set; }

        /// <summary>
        /// Gets or Sets BannerUrl
        /// </summary>
        [DataMember(Name = "bannerUrl", EmitDefaultValue = false)]
        public string BannerUrl { get; set; }

        /// <summary>
        /// Gets or Sets Bio
        /// </summary>
        [DataMember(Name = "bio", EmitDefaultValue = false)]
        public string Bio { get; set; }

        /// <summary>
        /// Gets or Sets BioLinks
        /// </summary>
        [DataMember(Name = "bioLinks", EmitDefaultValue = false)]
        public List<string> BioLinks { get; set; }

        /// <summary>
        /// Gets or Sets CurrentAvatar
        /// </summary>
        /*
        <example>avtr_912d66a4-4714-43b8-8407-7de2cafbf55b</example>
        */
        [DataMember(Name = "currentAvatar", EmitDefaultValue = false)]
        public string CurrentAvatar { get; set; }

        /// <summary>
        /// Gets or Sets CurrentAvatarAuthorName
        /// </summary>
        [DataMember(Name = "currentAvatarAuthorName", EmitDefaultValue = false)]
        public string CurrentAvatarAuthorName { get; set; }

        /// <summary>
        /// When profilePicOverride is not empty, use it instead.
        /// </summary>
        /// <value>When profilePicOverride is not empty, use it instead.</value>
        /*
        <example>https://api.vrchat.cloud/api/1/file/file_ae46d521-7281-4b38-b365-804b32a1d6a7/1/file</example>
        */
        [DataMember(Name = "currentAvatarImageUrl", EmitDefaultValue = false)]
        public string CurrentAvatarImageUrl { get; set; }

        /// <summary>
        /// Gets or Sets CurrentAvatarName
        /// </summary>
        [DataMember(Name = "currentAvatarName", EmitDefaultValue = false)]
        public string CurrentAvatarName { get; set; }

        /// <summary>
        /// Gets or Sets CurrentAvatarTags
        /// </summary>
        [DataMember(Name = "currentAvatarTags", EmitDefaultValue = false)]
        public List<string> CurrentAvatarTags { get; set; }

        /// <summary>
        /// When profilePicOverride is not empty, use it instead.
        /// </summary>
        /// <value>When profilePicOverride is not empty, use it instead.</value>
        /*
        <example>https://api.vrchat.cloud/api/1/image/file_aae83ed9-d42d-4d72-9f4b-9f1e41ed17e1/1/256</example>
        */
        [DataMember(Name = "currentAvatarThumbnailImageUrl", EmitDefaultValue = false)]
        public string CurrentAvatarThumbnailImageUrl { get; set; }

        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name = "displayName", EmitDefaultValue = false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets Groups
        /// </summary>
        [DataMember(Name = "groups", EmitDefaultValue = false)]
        public ProfileGroups Groups { get; set; }

        /// <summary>
        /// Gets or Sets HasVrcPlus
        /// </summary>
        [DataMember(Name = "hasVrcPlus", EmitDefaultValue = true)]
        public bool HasVrcPlus { get; set; }

        /// <summary>
        /// Gets or Sets IconFrame
        /// </summary>
        [DataMember(Name = "iconFrame", EmitDefaultValue = false)]
        public string IconFrame { get; set; }

        /// <summary>
        /// Gets or Sets IconType
        /// </summary>
        [DataMember(Name = "iconType", EmitDefaultValue = false)]
        public string IconType { get; set; }

        /// <summary>
        /// Gets or Sets IconUrl
        /// </summary>
        [DataMember(Name = "iconUrl", EmitDefaultValue = false)]
        public string IconUrl { get; set; }

        /// <summary>
        /// A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed.
        /// </summary>
        /// <value>A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed.</value>
        /*
        <example>usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469</example>
        */
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets IsEconomyCreator
        /// </summary>
        [DataMember(Name = "isEconomyCreator", EmitDefaultValue = true)]
        public bool IsEconomyCreator { get; set; }

        /// <summary>
        /// Gets or Sets Languages
        /// </summary>
        [DataMember(Name = "languages", EmitDefaultValue = false)]
        public List<string> Languages { get; set; }

        /// <summary>
        /// Gets or Sets NameplateEffect
        /// </summary>
        [DataMember(Name = "nameplateEffect", EmitDefaultValue = false)]
        public string NameplateEffect { get; set; }

        /// <summary>
        /// Gets or Sets ProfileEffect
        /// </summary>
        [DataMember(Name = "profileEffect", EmitDefaultValue = false)]
        public string ProfileEffect { get; set; }

        /// <summary>
        /// Gets or Sets Pronouns
        /// </summary>
        [DataMember(Name = "pronouns", EmitDefaultValue = false)]
        public string Pronouns { get; set; }

        /// <summary>
        /// Gets or Sets PublicWorlds
        /// </summary>
        [DataMember(Name = "publicWorlds", EmitDefaultValue = false)]
        public List<LimitedWorld> PublicWorlds { get; set; }

        /// <summary>
        /// Gets or Sets RepresentedGroup
        /// </summary>
        [DataMember(Name = "representedGroup", EmitDefaultValue = false)]
        public ProfileRepresentedGroup RepresentedGroup { get; set; }

        /// <summary>
        /// Gets or Sets StatusDescription
        /// </summary>
        [DataMember(Name = "statusDescription", EmitDefaultValue = false)]
        public string StatusDescription { get; set; }

        /// <summary>
        /// Six hexadecimal digits, without a leading &#x60;#&#x60;. May be empty.
        /// </summary>
        /// <value>Six hexadecimal digits, without a leading &#x60;#&#x60;. May be empty.</value>
        /*
        <example>3cc92c</example>
        */
        [DataMember(Name = "themeButtonColor", EmitDefaultValue = false)]
        public string ThemeButtonColor { get; set; }

        /// <summary>
        /// Six hexadecimal digits, without a leading &#x60;#&#x60;. May be empty.
        /// </summary>
        /// <value>Six hexadecimal digits, without a leading &#x60;#&#x60;. May be empty.</value>
        /*
        <example>3cc92c</example>
        */
        [DataMember(Name = "themeIconColor", EmitDefaultValue = false)]
        public string ThemeIconColor { get; set; }

        /// <summary>
        /// Gets or Sets ThemeId
        /// </summary>
        [DataMember(Name = "themeId", EmitDefaultValue = false)]
        public string ThemeId { get; set; }

        /// <summary>
        /// Six hexadecimal digits, without a leading &#x60;#&#x60;. May be empty.
        /// </summary>
        /// <value>Six hexadecimal digits, without a leading &#x60;#&#x60;. May be empty.</value>
        /*
        <example>3cc92c</example>
        */
        [DataMember(Name = "themeSubtextColor", EmitDefaultValue = false)]
        public string ThemeSubtextColor { get; set; }

        /// <summary>
        /// Gets or Sets Themes
        /// </summary>
        [DataMember(Name = "themes", EmitDefaultValue = false)]
        public List<Object> Themes { get; set; }

        /// <summary>
        /// Gets or Sets TotalPublicWorldsCount
        /// </summary>
        [DataMember(Name = "totalPublicWorldsCount", EmitDefaultValue = false)]
        public int TotalPublicWorldsCount { get; set; }

        /// <summary>
        /// Gets or Sets TrustTags
        /// </summary>
        [DataMember(Name = "trustTags", EmitDefaultValue = false)]
        public List<string> TrustTags { get; set; }

        /// <summary>
        /// Gets or Sets UserIcon
        /// </summary>
        [DataMember(Name = "userIcon", EmitDefaultValue = false)]
        public string UserIcon { get; set; }

        /// <summary>
        /// The owner&#39;s public world favorite groups.
        /// </summary>
        /// <value>The owner&#39;s public world favorite groups.</value>
        [DataMember(Name = "worldFavoriteLists", EmitDefaultValue = false)]
        public List<WorldFavoriteList> WorldFavoriteLists { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PublicProfile {\n");
            sb.Append("  AgeVerificationStatus: ").Append(AgeVerificationStatus).Append("\n");
            sb.Append("  AgeVerified: ").Append(AgeVerified).Append("\n");
            sb.Append("  BackgroundGradientBottom: ").Append(BackgroundGradientBottom).Append("\n");
            sb.Append("  BackgroundGradientTop: ").Append(BackgroundGradientTop).Append("\n");
            sb.Append("  BackgroundTemplateId: ").Append(BackgroundTemplateId).Append("\n");
            sb.Append("  BackgroundTextureId: ").Append(BackgroundTextureId).Append("\n");
            sb.Append("  BackgroundType: ").Append(BackgroundType).Append("\n");
            sb.Append("  Badges: ").Append(Badges).Append("\n");
            sb.Append("  BannerColor: ").Append(BannerColor).Append("\n");
            sb.Append("  BannerCustomUrl: ").Append(BannerCustomUrl).Append("\n");
            sb.Append("  BannerType: ").Append(BannerType).Append("\n");
            sb.Append("  BannerUrl: ").Append(BannerUrl).Append("\n");
            sb.Append("  Bio: ").Append(Bio).Append("\n");
            sb.Append("  BioLinks: ").Append(BioLinks).Append("\n");
            sb.Append("  CurrentAvatar: ").Append(CurrentAvatar).Append("\n");
            sb.Append("  CurrentAvatarAuthorName: ").Append(CurrentAvatarAuthorName).Append("\n");
            sb.Append("  CurrentAvatarImageUrl: ").Append(CurrentAvatarImageUrl).Append("\n");
            sb.Append("  CurrentAvatarName: ").Append(CurrentAvatarName).Append("\n");
            sb.Append("  CurrentAvatarTags: ").Append(CurrentAvatarTags).Append("\n");
            sb.Append("  CurrentAvatarThumbnailImageUrl: ").Append(CurrentAvatarThumbnailImageUrl).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Groups: ").Append(Groups).Append("\n");
            sb.Append("  HasVrcPlus: ").Append(HasVrcPlus).Append("\n");
            sb.Append("  IconFrame: ").Append(IconFrame).Append("\n");
            sb.Append("  IconType: ").Append(IconType).Append("\n");
            sb.Append("  IconUrl: ").Append(IconUrl).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IsEconomyCreator: ").Append(IsEconomyCreator).Append("\n");
            sb.Append("  Languages: ").Append(Languages).Append("\n");
            sb.Append("  NameplateEffect: ").Append(NameplateEffect).Append("\n");
            sb.Append("  ProfileEffect: ").Append(ProfileEffect).Append("\n");
            sb.Append("  Pronouns: ").Append(Pronouns).Append("\n");
            sb.Append("  PublicWorlds: ").Append(PublicWorlds).Append("\n");
            sb.Append("  RepresentedGroup: ").Append(RepresentedGroup).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  StatusDescription: ").Append(StatusDescription).Append("\n");
            sb.Append("  ThemeButtonColor: ").Append(ThemeButtonColor).Append("\n");
            sb.Append("  ThemeIconColor: ").Append(ThemeIconColor).Append("\n");
            sb.Append("  ThemeId: ").Append(ThemeId).Append("\n");
            sb.Append("  ThemeSubtextColor: ").Append(ThemeSubtextColor).Append("\n");
            sb.Append("  Themes: ").Append(Themes).Append("\n");
            sb.Append("  TotalPublicWorldsCount: ").Append(TotalPublicWorldsCount).Append("\n");
            sb.Append("  TrustTags: ").Append(TrustTags).Append("\n");
            sb.Append("  UserIcon: ").Append(UserIcon).Append("\n");
            sb.Append("  WorldFavoriteLists: ").Append(WorldFavoriteLists).Append("\n");
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
            return this.Equals(input as PublicProfile);
        }

        /// <summary>
        /// Returns true if PublicProfile instances are equal
        /// </summary>
        /// <param name="input">Instance of PublicProfile to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PublicProfile input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AgeVerificationStatus == input.AgeVerificationStatus ||
                    this.AgeVerificationStatus.Equals(input.AgeVerificationStatus)
                ) && 
                (
                    this.AgeVerified == input.AgeVerified ||
                    this.AgeVerified.Equals(input.AgeVerified)
                ) && 
                (
                    this.BackgroundGradientBottom == input.BackgroundGradientBottom ||
                    (this.BackgroundGradientBottom != null &&
                    this.BackgroundGradientBottom.Equals(input.BackgroundGradientBottom))
                ) && 
                (
                    this.BackgroundGradientTop == input.BackgroundGradientTop ||
                    (this.BackgroundGradientTop != null &&
                    this.BackgroundGradientTop.Equals(input.BackgroundGradientTop))
                ) && 
                (
                    this.BackgroundTemplateId == input.BackgroundTemplateId ||
                    (this.BackgroundTemplateId != null &&
                    this.BackgroundTemplateId.Equals(input.BackgroundTemplateId))
                ) && 
                (
                    this.BackgroundTextureId == input.BackgroundTextureId ||
                    (this.BackgroundTextureId != null &&
                    this.BackgroundTextureId.Equals(input.BackgroundTextureId))
                ) && 
                (
                    this.BackgroundType == input.BackgroundType ||
                    (this.BackgroundType != null &&
                    this.BackgroundType.Equals(input.BackgroundType))
                ) && 
                (
                    this.Badges == input.Badges ||
                    this.Badges != null &&
                    input.Badges != null &&
                    this.Badges.SequenceEqual(input.Badges)
                ) && 
                (
                    this.BannerColor == input.BannerColor ||
                    (this.BannerColor != null &&
                    this.BannerColor.Equals(input.BannerColor))
                ) && 
                (
                    this.BannerCustomUrl == input.BannerCustomUrl ||
                    (this.BannerCustomUrl != null &&
                    this.BannerCustomUrl.Equals(input.BannerCustomUrl))
                ) && 
                (
                    this.BannerType == input.BannerType ||
                    (this.BannerType != null &&
                    this.BannerType.Equals(input.BannerType))
                ) && 
                (
                    this.BannerUrl == input.BannerUrl ||
                    (this.BannerUrl != null &&
                    this.BannerUrl.Equals(input.BannerUrl))
                ) && 
                (
                    this.Bio == input.Bio ||
                    (this.Bio != null &&
                    this.Bio.Equals(input.Bio))
                ) && 
                (
                    this.BioLinks == input.BioLinks ||
                    this.BioLinks != null &&
                    input.BioLinks != null &&
                    this.BioLinks.SequenceEqual(input.BioLinks)
                ) && 
                (
                    this.CurrentAvatar == input.CurrentAvatar ||
                    (this.CurrentAvatar != null &&
                    this.CurrentAvatar.Equals(input.CurrentAvatar))
                ) && 
                (
                    this.CurrentAvatarAuthorName == input.CurrentAvatarAuthorName ||
                    (this.CurrentAvatarAuthorName != null &&
                    this.CurrentAvatarAuthorName.Equals(input.CurrentAvatarAuthorName))
                ) && 
                (
                    this.CurrentAvatarImageUrl == input.CurrentAvatarImageUrl ||
                    (this.CurrentAvatarImageUrl != null &&
                    this.CurrentAvatarImageUrl.Equals(input.CurrentAvatarImageUrl))
                ) && 
                (
                    this.CurrentAvatarName == input.CurrentAvatarName ||
                    (this.CurrentAvatarName != null &&
                    this.CurrentAvatarName.Equals(input.CurrentAvatarName))
                ) && 
                (
                    this.CurrentAvatarTags == input.CurrentAvatarTags ||
                    this.CurrentAvatarTags != null &&
                    input.CurrentAvatarTags != null &&
                    this.CurrentAvatarTags.SequenceEqual(input.CurrentAvatarTags)
                ) && 
                (
                    this.CurrentAvatarThumbnailImageUrl == input.CurrentAvatarThumbnailImageUrl ||
                    (this.CurrentAvatarThumbnailImageUrl != null &&
                    this.CurrentAvatarThumbnailImageUrl.Equals(input.CurrentAvatarThumbnailImageUrl))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.Groups == input.Groups ||
                    (this.Groups != null &&
                    this.Groups.Equals(input.Groups))
                ) && 
                (
                    this.HasVrcPlus == input.HasVrcPlus ||
                    this.HasVrcPlus.Equals(input.HasVrcPlus)
                ) && 
                (
                    this.IconFrame == input.IconFrame ||
                    (this.IconFrame != null &&
                    this.IconFrame.Equals(input.IconFrame))
                ) && 
                (
                    this.IconType == input.IconType ||
                    (this.IconType != null &&
                    this.IconType.Equals(input.IconType))
                ) && 
                (
                    this.IconUrl == input.IconUrl ||
                    (this.IconUrl != null &&
                    this.IconUrl.Equals(input.IconUrl))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.IsEconomyCreator == input.IsEconomyCreator ||
                    this.IsEconomyCreator.Equals(input.IsEconomyCreator)
                ) && 
                (
                    this.Languages == input.Languages ||
                    this.Languages != null &&
                    input.Languages != null &&
                    this.Languages.SequenceEqual(input.Languages)
                ) && 
                (
                    this.NameplateEffect == input.NameplateEffect ||
                    (this.NameplateEffect != null &&
                    this.NameplateEffect.Equals(input.NameplateEffect))
                ) && 
                (
                    this.ProfileEffect == input.ProfileEffect ||
                    (this.ProfileEffect != null &&
                    this.ProfileEffect.Equals(input.ProfileEffect))
                ) && 
                (
                    this.Pronouns == input.Pronouns ||
                    (this.Pronouns != null &&
                    this.Pronouns.Equals(input.Pronouns))
                ) && 
                (
                    this.PublicWorlds == input.PublicWorlds ||
                    this.PublicWorlds != null &&
                    input.PublicWorlds != null &&
                    this.PublicWorlds.SequenceEqual(input.PublicWorlds)
                ) && 
                (
                    this.RepresentedGroup == input.RepresentedGroup ||
                    (this.RepresentedGroup != null &&
                    this.RepresentedGroup.Equals(input.RepresentedGroup))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.StatusDescription == input.StatusDescription ||
                    (this.StatusDescription != null &&
                    this.StatusDescription.Equals(input.StatusDescription))
                ) && 
                (
                    this.ThemeButtonColor == input.ThemeButtonColor ||
                    (this.ThemeButtonColor != null &&
                    this.ThemeButtonColor.Equals(input.ThemeButtonColor))
                ) && 
                (
                    this.ThemeIconColor == input.ThemeIconColor ||
                    (this.ThemeIconColor != null &&
                    this.ThemeIconColor.Equals(input.ThemeIconColor))
                ) && 
                (
                    this.ThemeId == input.ThemeId ||
                    (this.ThemeId != null &&
                    this.ThemeId.Equals(input.ThemeId))
                ) && 
                (
                    this.ThemeSubtextColor == input.ThemeSubtextColor ||
                    (this.ThemeSubtextColor != null &&
                    this.ThemeSubtextColor.Equals(input.ThemeSubtextColor))
                ) && 
                (
                    this.Themes == input.Themes ||
                    this.Themes != null &&
                    input.Themes != null &&
                    this.Themes.SequenceEqual(input.Themes)
                ) && 
                (
                    this.TotalPublicWorldsCount == input.TotalPublicWorldsCount ||
                    this.TotalPublicWorldsCount.Equals(input.TotalPublicWorldsCount)
                ) && 
                (
                    this.TrustTags == input.TrustTags ||
                    this.TrustTags != null &&
                    input.TrustTags != null &&
                    this.TrustTags.SequenceEqual(input.TrustTags)
                ) && 
                (
                    this.UserIcon == input.UserIcon ||
                    (this.UserIcon != null &&
                    this.UserIcon.Equals(input.UserIcon))
                ) && 
                (
                    this.WorldFavoriteLists == input.WorldFavoriteLists ||
                    this.WorldFavoriteLists != null &&
                    input.WorldFavoriteLists != null &&
                    this.WorldFavoriteLists.SequenceEqual(input.WorldFavoriteLists)
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
                hashCode = (hashCode * 59) + this.AgeVerificationStatus.GetHashCode();
                hashCode = (hashCode * 59) + this.AgeVerified.GetHashCode();
                if (this.BackgroundGradientBottom != null)
                {
                    hashCode = (hashCode * 59) + this.BackgroundGradientBottom.GetHashCode();
                }
                if (this.BackgroundGradientTop != null)
                {
                    hashCode = (hashCode * 59) + this.BackgroundGradientTop.GetHashCode();
                }
                if (this.BackgroundTemplateId != null)
                {
                    hashCode = (hashCode * 59) + this.BackgroundTemplateId.GetHashCode();
                }
                if (this.BackgroundTextureId != null)
                {
                    hashCode = (hashCode * 59) + this.BackgroundTextureId.GetHashCode();
                }
                if (this.BackgroundType != null)
                {
                    hashCode = (hashCode * 59) + this.BackgroundType.GetHashCode();
                }
                if (this.Badges != null)
                {
                    hashCode = (hashCode * 59) + this.Badges.GetHashCode();
                }
                if (this.BannerColor != null)
                {
                    hashCode = (hashCode * 59) + this.BannerColor.GetHashCode();
                }
                if (this.BannerCustomUrl != null)
                {
                    hashCode = (hashCode * 59) + this.BannerCustomUrl.GetHashCode();
                }
                if (this.BannerType != null)
                {
                    hashCode = (hashCode * 59) + this.BannerType.GetHashCode();
                }
                if (this.BannerUrl != null)
                {
                    hashCode = (hashCode * 59) + this.BannerUrl.GetHashCode();
                }
                if (this.Bio != null)
                {
                    hashCode = (hashCode * 59) + this.Bio.GetHashCode();
                }
                if (this.BioLinks != null)
                {
                    hashCode = (hashCode * 59) + this.BioLinks.GetHashCode();
                }
                if (this.CurrentAvatar != null)
                {
                    hashCode = (hashCode * 59) + this.CurrentAvatar.GetHashCode();
                }
                if (this.CurrentAvatarAuthorName != null)
                {
                    hashCode = (hashCode * 59) + this.CurrentAvatarAuthorName.GetHashCode();
                }
                if (this.CurrentAvatarImageUrl != null)
                {
                    hashCode = (hashCode * 59) + this.CurrentAvatarImageUrl.GetHashCode();
                }
                if (this.CurrentAvatarName != null)
                {
                    hashCode = (hashCode * 59) + this.CurrentAvatarName.GetHashCode();
                }
                if (this.CurrentAvatarTags != null)
                {
                    hashCode = (hashCode * 59) + this.CurrentAvatarTags.GetHashCode();
                }
                if (this.CurrentAvatarThumbnailImageUrl != null)
                {
                    hashCode = (hashCode * 59) + this.CurrentAvatarThumbnailImageUrl.GetHashCode();
                }
                if (this.DisplayName != null)
                {
                    hashCode = (hashCode * 59) + this.DisplayName.GetHashCode();
                }
                if (this.Groups != null)
                {
                    hashCode = (hashCode * 59) + this.Groups.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.HasVrcPlus.GetHashCode();
                if (this.IconFrame != null)
                {
                    hashCode = (hashCode * 59) + this.IconFrame.GetHashCode();
                }
                if (this.IconType != null)
                {
                    hashCode = (hashCode * 59) + this.IconType.GetHashCode();
                }
                if (this.IconUrl != null)
                {
                    hashCode = (hashCode * 59) + this.IconUrl.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsEconomyCreator.GetHashCode();
                if (this.Languages != null)
                {
                    hashCode = (hashCode * 59) + this.Languages.GetHashCode();
                }
                if (this.NameplateEffect != null)
                {
                    hashCode = (hashCode * 59) + this.NameplateEffect.GetHashCode();
                }
                if (this.ProfileEffect != null)
                {
                    hashCode = (hashCode * 59) + this.ProfileEffect.GetHashCode();
                }
                if (this.Pronouns != null)
                {
                    hashCode = (hashCode * 59) + this.Pronouns.GetHashCode();
                }
                if (this.PublicWorlds != null)
                {
                    hashCode = (hashCode * 59) + this.PublicWorlds.GetHashCode();
                }
                if (this.RepresentedGroup != null)
                {
                    hashCode = (hashCode * 59) + this.RepresentedGroup.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                if (this.StatusDescription != null)
                {
                    hashCode = (hashCode * 59) + this.StatusDescription.GetHashCode();
                }
                if (this.ThemeButtonColor != null)
                {
                    hashCode = (hashCode * 59) + this.ThemeButtonColor.GetHashCode();
                }
                if (this.ThemeIconColor != null)
                {
                    hashCode = (hashCode * 59) + this.ThemeIconColor.GetHashCode();
                }
                if (this.ThemeId != null)
                {
                    hashCode = (hashCode * 59) + this.ThemeId.GetHashCode();
                }
                if (this.ThemeSubtextColor != null)
                {
                    hashCode = (hashCode * 59) + this.ThemeSubtextColor.GetHashCode();
                }
                if (this.Themes != null)
                {
                    hashCode = (hashCode * 59) + this.Themes.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TotalPublicWorldsCount.GetHashCode();
                if (this.TrustTags != null)
                {
                    hashCode = (hashCode * 59) + this.TrustTags.GetHashCode();
                }
                if (this.UserIcon != null)
                {
                    hashCode = (hashCode * 59) + this.UserIcon.GetHashCode();
                }
                if (this.WorldFavoriteLists != null)
                {
                    hashCode = (hashCode * 59) + this.WorldFavoriteLists.GetHashCode();
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
            yield break;
        }
    }

}
