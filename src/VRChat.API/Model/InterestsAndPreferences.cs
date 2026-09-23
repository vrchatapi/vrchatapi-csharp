

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
    /// Interests and preferences the current user has turned on. A key is present only while its value is &#x60;true&#x60;.
    /// </summary>
    [DataContract(Name = "InterestsAndPreferences")]
    public partial class InterestsAndPreferences : IEquatable<InterestsAndPreferences>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InterestsAndPreferences" /> class.
        /// </summary>
        /// <param name="anime">anime.</param>
        /// <param name="art">art.</param>
        /// <param name="avatars">avatars.</param>
        /// <param name="bigGroup">bigGroup.</param>
        /// <param name="explore">explore.</param>
        /// <param name="fantasy">fantasy.</param>
        /// <param name="fashion">fashion.</param>
        /// <param name="findAvatars">findAvatars.</param>
        /// <param name="furries">furries.</param>
        /// <param name="horror">horror.</param>
        /// <param name="languageLearning">languageLearning.</param>
        /// <param name="meetPeople">meetPeople.</param>
        /// <param name="music">music.</param>
        /// <param name="mystery">mystery.</param>
        /// <param name="sciFi">sciFi.</param>
        /// <param name="smallGroup">smallGroup.</param>
        /// <param name="surprise">surprise.</param>
        public InterestsAndPreferences(bool anime = default, bool art = default, bool avatars = default, bool bigGroup = default, bool explore = default, bool fantasy = default, bool fashion = default, bool findAvatars = default, bool furries = default, bool horror = default, bool languageLearning = default, bool meetPeople = default, bool music = default, bool mystery = default, bool sciFi = default, bool smallGroup = default, bool surprise = default)
        {
            this.Anime = anime;
            this.Art = art;
            this.Avatars = avatars;
            this.BigGroup = bigGroup;
            this.Explore = explore;
            this.Fantasy = fantasy;
            this.Fashion = fashion;
            this.FindAvatars = findAvatars;
            this.Furries = furries;
            this.Horror = horror;
            this.LanguageLearning = languageLearning;
            this.MeetPeople = meetPeople;
            this.Music = music;
            this.Mystery = mystery;
            this.SciFi = sciFi;
            this.SmallGroup = smallGroup;
            this.Surprise = surprise;
        }

        /// <summary>
        /// Gets or Sets Anime
        /// </summary>
        [DataMember(Name = "Anime", EmitDefaultValue = true)]
        public bool Anime { get; set; }

        /// <summary>
        /// Gets or Sets Art
        /// </summary>
        [DataMember(Name = "Art", EmitDefaultValue = true)]
        public bool Art { get; set; }

        /// <summary>
        /// Gets or Sets Avatars
        /// </summary>
        [DataMember(Name = "Avatars", EmitDefaultValue = true)]
        public bool Avatars { get; set; }

        /// <summary>
        /// Gets or Sets BigGroup
        /// </summary>
        [DataMember(Name = "BigGroup", EmitDefaultValue = true)]
        public bool BigGroup { get; set; }

        /// <summary>
        /// Gets or Sets Explore
        /// </summary>
        [DataMember(Name = "Explore", EmitDefaultValue = true)]
        public bool Explore { get; set; }

        /// <summary>
        /// Gets or Sets Fantasy
        /// </summary>
        [DataMember(Name = "Fantasy", EmitDefaultValue = true)]
        public bool Fantasy { get; set; }

        /// <summary>
        /// Gets or Sets Fashion
        /// </summary>
        [DataMember(Name = "Fashion", EmitDefaultValue = true)]
        public bool Fashion { get; set; }

        /// <summary>
        /// Gets or Sets FindAvatars
        /// </summary>
        [DataMember(Name = "FindAvatars", EmitDefaultValue = true)]
        public bool FindAvatars { get; set; }

        /// <summary>
        /// Gets or Sets Furries
        /// </summary>
        [DataMember(Name = "Furries", EmitDefaultValue = true)]
        public bool Furries { get; set; }

        /// <summary>
        /// Gets or Sets Horror
        /// </summary>
        [DataMember(Name = "Horror", EmitDefaultValue = true)]
        public bool Horror { get; set; }

        /// <summary>
        /// Gets or Sets LanguageLearning
        /// </summary>
        [DataMember(Name = "LanguageLearning", EmitDefaultValue = true)]
        public bool LanguageLearning { get; set; }

        /// <summary>
        /// Gets or Sets MeetPeople
        /// </summary>
        [DataMember(Name = "MeetPeople", EmitDefaultValue = true)]
        public bool MeetPeople { get; set; }

        /// <summary>
        /// Gets or Sets Music
        /// </summary>
        [DataMember(Name = "Music", EmitDefaultValue = true)]
        public bool Music { get; set; }

        /// <summary>
        /// Gets or Sets Mystery
        /// </summary>
        [DataMember(Name = "Mystery", EmitDefaultValue = true)]
        public bool Mystery { get; set; }

        /// <summary>
        /// Gets or Sets SciFi
        /// </summary>
        [DataMember(Name = "SciFi", EmitDefaultValue = true)]
        public bool SciFi { get; set; }

        /// <summary>
        /// Gets or Sets SmallGroup
        /// </summary>
        [DataMember(Name = "SmallGroup", EmitDefaultValue = true)]
        public bool SmallGroup { get; set; }

        /// <summary>
        /// Gets or Sets Surprise
        /// </summary>
        [DataMember(Name = "Surprise", EmitDefaultValue = true)]
        public bool Surprise { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InterestsAndPreferences {\n");
            sb.Append("  Anime: ").Append(Anime).Append("\n");
            sb.Append("  Art: ").Append(Art).Append("\n");
            sb.Append("  Avatars: ").Append(Avatars).Append("\n");
            sb.Append("  BigGroup: ").Append(BigGroup).Append("\n");
            sb.Append("  Explore: ").Append(Explore).Append("\n");
            sb.Append("  Fantasy: ").Append(Fantasy).Append("\n");
            sb.Append("  Fashion: ").Append(Fashion).Append("\n");
            sb.Append("  FindAvatars: ").Append(FindAvatars).Append("\n");
            sb.Append("  Furries: ").Append(Furries).Append("\n");
            sb.Append("  Horror: ").Append(Horror).Append("\n");
            sb.Append("  LanguageLearning: ").Append(LanguageLearning).Append("\n");
            sb.Append("  MeetPeople: ").Append(MeetPeople).Append("\n");
            sb.Append("  Music: ").Append(Music).Append("\n");
            sb.Append("  Mystery: ").Append(Mystery).Append("\n");
            sb.Append("  SciFi: ").Append(SciFi).Append("\n");
            sb.Append("  SmallGroup: ").Append(SmallGroup).Append("\n");
            sb.Append("  Surprise: ").Append(Surprise).Append("\n");
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
            return this.Equals(input as InterestsAndPreferences);
        }

        /// <summary>
        /// Returns true if InterestsAndPreferences instances are equal
        /// </summary>
        /// <param name="input">Instance of InterestsAndPreferences to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InterestsAndPreferences input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Anime == input.Anime ||
                    this.Anime.Equals(input.Anime)
                ) && 
                (
                    this.Art == input.Art ||
                    this.Art.Equals(input.Art)
                ) && 
                (
                    this.Avatars == input.Avatars ||
                    this.Avatars.Equals(input.Avatars)
                ) && 
                (
                    this.BigGroup == input.BigGroup ||
                    this.BigGroup.Equals(input.BigGroup)
                ) && 
                (
                    this.Explore == input.Explore ||
                    this.Explore.Equals(input.Explore)
                ) && 
                (
                    this.Fantasy == input.Fantasy ||
                    this.Fantasy.Equals(input.Fantasy)
                ) && 
                (
                    this.Fashion == input.Fashion ||
                    this.Fashion.Equals(input.Fashion)
                ) && 
                (
                    this.FindAvatars == input.FindAvatars ||
                    this.FindAvatars.Equals(input.FindAvatars)
                ) && 
                (
                    this.Furries == input.Furries ||
                    this.Furries.Equals(input.Furries)
                ) && 
                (
                    this.Horror == input.Horror ||
                    this.Horror.Equals(input.Horror)
                ) && 
                (
                    this.LanguageLearning == input.LanguageLearning ||
                    this.LanguageLearning.Equals(input.LanguageLearning)
                ) && 
                (
                    this.MeetPeople == input.MeetPeople ||
                    this.MeetPeople.Equals(input.MeetPeople)
                ) && 
                (
                    this.Music == input.Music ||
                    this.Music.Equals(input.Music)
                ) && 
                (
                    this.Mystery == input.Mystery ||
                    this.Mystery.Equals(input.Mystery)
                ) && 
                (
                    this.SciFi == input.SciFi ||
                    this.SciFi.Equals(input.SciFi)
                ) && 
                (
                    this.SmallGroup == input.SmallGroup ||
                    this.SmallGroup.Equals(input.SmallGroup)
                ) && 
                (
                    this.Surprise == input.Surprise ||
                    this.Surprise.Equals(input.Surprise)
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
                hashCode = (hashCode * 59) + this.Anime.GetHashCode();
                hashCode = (hashCode * 59) + this.Art.GetHashCode();
                hashCode = (hashCode * 59) + this.Avatars.GetHashCode();
                hashCode = (hashCode * 59) + this.BigGroup.GetHashCode();
                hashCode = (hashCode * 59) + this.Explore.GetHashCode();
                hashCode = (hashCode * 59) + this.Fantasy.GetHashCode();
                hashCode = (hashCode * 59) + this.Fashion.GetHashCode();
                hashCode = (hashCode * 59) + this.FindAvatars.GetHashCode();
                hashCode = (hashCode * 59) + this.Furries.GetHashCode();
                hashCode = (hashCode * 59) + this.Horror.GetHashCode();
                hashCode = (hashCode * 59) + this.LanguageLearning.GetHashCode();
                hashCode = (hashCode * 59) + this.MeetPeople.GetHashCode();
                hashCode = (hashCode * 59) + this.Music.GetHashCode();
                hashCode = (hashCode * 59) + this.Mystery.GetHashCode();
                hashCode = (hashCode * 59) + this.SciFi.GetHashCode();
                hashCode = (hashCode * 59) + this.SmallGroup.GetHashCode();
                hashCode = (hashCode * 59) + this.Surprise.GetHashCode();
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
