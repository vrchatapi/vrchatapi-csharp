/*
 * VRChat API Documentation
 *
 *
 * The version of the OpenAPI document: 1.19.2
 * Contact: vrchatapi.lpv0t@aries.fyi
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


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
using OpenAPIDateConverter = VRChat.API.Client.OpenAPIDateConverter;

namespace VRChat.API.Model
{
    /// <summary>
    /// FileAnalysisAvatarStats
    /// </summary>
    [DataContract(Name = "FileAnalysisAvatarStats")]
    public partial class FileAnalysisAvatarStats : IEquatable<FileAnalysisAvatarStats>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileAnalysisAvatarStats" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FileAnalysisAvatarStats() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FileAnalysisAvatarStats" /> class.
        /// </summary>
        /// <param name="animatorCount">animatorCount (required).</param>
        /// <param name="audioSourceCount">audioSourceCount (required).</param>
        /// <param name="blendShapeCount">blendShapeCount (required).</param>
        /// <param name="boneCount">boneCount (required).</param>
        /// <param name="bounds">bounds (required).</param>
        /// <param name="cameraCount">cameraCount.</param>
        /// <param name="clothCount">clothCount (required).</param>
        /// <param name="constraintCount">constraintCount (required).</param>
        /// <param name="contactCount">contactCount (required).</param>
        /// <param name="customExpressions">customExpressions (required).</param>
        /// <param name="customizeAnimationLayers">customizeAnimationLayers (required).</param>
        /// <param name="enableEyeLook">enableEyeLook (required).</param>
        /// <param name="lightCount">lightCount (required).</param>
        /// <param name="lineRendererCount">lineRendererCount (required).</param>
        /// <param name="lipSync">lipSync (required).</param>
        /// <param name="materialCount">materialCount (required).</param>
        /// <param name="materialSlotsUsed">materialSlotsUsed (required).</param>
        /// <param name="meshCount">meshCount (required).</param>
        /// <param name="meshIndices">meshIndices (required).</param>
        /// <param name="meshParticleMaxPolygons">meshParticleMaxPolygons (required).</param>
        /// <param name="meshPolygons">meshPolygons (required).</param>
        /// <param name="meshVertices">meshVertices (required).</param>
        /// <param name="particleCollisionEnabled">particleCollisionEnabled (required).</param>
        /// <param name="particleSystemCount">particleSystemCount (required).</param>
        /// <param name="particleTrailsEnabled">particleTrailsEnabled (required).</param>
        /// <param name="physBoneColliderCount">physBoneColliderCount (required).</param>
        /// <param name="physBoneCollisionCheckCount">physBoneCollisionCheckCount (required).</param>
        /// <param name="physBoneComponentCount">physBoneComponentCount (required).</param>
        /// <param name="physBoneTransformCount">physBoneTransformCount (required).</param>
        /// <param name="physicsColliders">physicsColliders (required).</param>
        /// <param name="physicsRigidbodies">physicsRigidbodies (required).</param>
        /// <param name="skinnedMeshCount">skinnedMeshCount (required).</param>
        /// <param name="skinnedMeshIndices">skinnedMeshIndices (required).</param>
        /// <param name="skinnedMeshPolygons">skinnedMeshPolygons (required).</param>
        /// <param name="skinnedMeshVertices">skinnedMeshVertices (required).</param>
        /// <param name="totalClothVertices">totalClothVertices (required).</param>
        /// <param name="totalIndices">totalIndices (required).</param>
        /// <param name="totalMaxParticles">totalMaxParticles (required).</param>
        /// <param name="totalPolygons">totalPolygons (required).</param>
        /// <param name="totalTextureUsage">totalTextureUsage (required).</param>
        /// <param name="totalVertices">totalVertices (required).</param>
        /// <param name="trailRendererCount">trailRendererCount (required).</param>
        /// <param name="writeDefaultsUsed">writeDefaultsUsed (required).</param>
        public FileAnalysisAvatarStats(int animatorCount = default(int), int audioSourceCount = default(int), int blendShapeCount = default(int), int boneCount = default(int), List<decimal> bounds = default(List<decimal>), int cameraCount = default(int), int clothCount = default(int), int constraintCount = default(int), int contactCount = default(int), bool customExpressions = default(bool), bool customizeAnimationLayers = default(bool), bool enableEyeLook = default(bool), int lightCount = default(int), int lineRendererCount = default(int), int lipSync = default(int), int materialCount = default(int), int materialSlotsUsed = default(int), int meshCount = default(int), int meshIndices = default(int), int meshParticleMaxPolygons = default(int), int meshPolygons = default(int), int meshVertices = default(int), bool particleCollisionEnabled = default(bool), int particleSystemCount = default(int), bool particleTrailsEnabled = default(bool), int physBoneColliderCount = default(int), int physBoneCollisionCheckCount = default(int), int physBoneComponentCount = default(int), int physBoneTransformCount = default(int), int physicsColliders = default(int), int physicsRigidbodies = default(int), int skinnedMeshCount = default(int), int skinnedMeshIndices = default(int), int skinnedMeshPolygons = default(int), int skinnedMeshVertices = default(int), int totalClothVertices = default(int), int totalIndices = default(int), int totalMaxParticles = default(int), int totalPolygons = default(int), int totalTextureUsage = default(int), int totalVertices = default(int), int trailRendererCount = default(int), bool writeDefaultsUsed = default(bool))
        {
            this.AnimatorCount = animatorCount;
            this.AudioSourceCount = audioSourceCount;
            this.BlendShapeCount = blendShapeCount;
            this.BoneCount = boneCount;
            // to ensure "bounds" is required (not null)
            if (bounds == null)
            {
                throw new ArgumentNullException("bounds is a required property for FileAnalysisAvatarStats and cannot be null");
            }
            this.Bounds = bounds;
            this.ClothCount = clothCount;
            this.ConstraintCount = constraintCount;
            this.ContactCount = contactCount;
            this.CustomExpressions = customExpressions;
            this.CustomizeAnimationLayers = customizeAnimationLayers;
            this.EnableEyeLook = enableEyeLook;
            this.LightCount = lightCount;
            this.LineRendererCount = lineRendererCount;
            this.LipSync = lipSync;
            this.MaterialCount = materialCount;
            this.MaterialSlotsUsed = materialSlotsUsed;
            this.MeshCount = meshCount;
            this.MeshIndices = meshIndices;
            this.MeshParticleMaxPolygons = meshParticleMaxPolygons;
            this.MeshPolygons = meshPolygons;
            this.MeshVertices = meshVertices;
            this.ParticleCollisionEnabled = particleCollisionEnabled;
            this.ParticleSystemCount = particleSystemCount;
            this.ParticleTrailsEnabled = particleTrailsEnabled;
            this.PhysBoneColliderCount = physBoneColliderCount;
            this.PhysBoneCollisionCheckCount = physBoneCollisionCheckCount;
            this.PhysBoneComponentCount = physBoneComponentCount;
            this.PhysBoneTransformCount = physBoneTransformCount;
            this.PhysicsColliders = physicsColliders;
            this.PhysicsRigidbodies = physicsRigidbodies;
            this.SkinnedMeshCount = skinnedMeshCount;
            this.SkinnedMeshIndices = skinnedMeshIndices;
            this.SkinnedMeshPolygons = skinnedMeshPolygons;
            this.SkinnedMeshVertices = skinnedMeshVertices;
            this.TotalClothVertices = totalClothVertices;
            this.TotalIndices = totalIndices;
            this.TotalMaxParticles = totalMaxParticles;
            this.TotalPolygons = totalPolygons;
            this.TotalTextureUsage = totalTextureUsage;
            this.TotalVertices = totalVertices;
            this.TrailRendererCount = trailRendererCount;
            this.WriteDefaultsUsed = writeDefaultsUsed;
            this.CameraCount = cameraCount;
        }

        /// <summary>
        /// Gets or Sets AnimatorCount
        /// </summary>
        [DataMember(Name = "animatorCount", IsRequired = true, EmitDefaultValue = true)]
        public int AnimatorCount { get; set; }

        /// <summary>
        /// Gets or Sets AudioSourceCount
        /// </summary>
        [DataMember(Name = "audioSourceCount", IsRequired = true, EmitDefaultValue = true)]
        public int AudioSourceCount { get; set; }

        /// <summary>
        /// Gets or Sets BlendShapeCount
        /// </summary>
        [DataMember(Name = "blendShapeCount", IsRequired = true, EmitDefaultValue = true)]
        public int BlendShapeCount { get; set; }

        /// <summary>
        /// Gets or Sets BoneCount
        /// </summary>
        [DataMember(Name = "boneCount", IsRequired = true, EmitDefaultValue = true)]
        public int BoneCount { get; set; }

        /// <summary>
        /// Gets or Sets Bounds
        /// </summary>
        [DataMember(Name = "bounds", IsRequired = true, EmitDefaultValue = true)]
        public List<decimal> Bounds { get; set; }

        /// <summary>
        /// Gets or Sets CameraCount
        /// </summary>
        [DataMember(Name = "cameraCount", EmitDefaultValue = false)]
        public int CameraCount { get; set; }

        /// <summary>
        /// Gets or Sets ClothCount
        /// </summary>
        [DataMember(Name = "clothCount", IsRequired = true, EmitDefaultValue = true)]
        public int ClothCount { get; set; }

        /// <summary>
        /// Gets or Sets ConstraintCount
        /// </summary>
        [DataMember(Name = "constraintCount", IsRequired = true, EmitDefaultValue = true)]
        public int ConstraintCount { get; set; }

        /// <summary>
        /// Gets or Sets ContactCount
        /// </summary>
        [DataMember(Name = "contactCount", IsRequired = true, EmitDefaultValue = true)]
        public int ContactCount { get; set; }

        /// <summary>
        /// Gets or Sets CustomExpressions
        /// </summary>
        [DataMember(Name = "customExpressions", IsRequired = true, EmitDefaultValue = true)]
        public bool CustomExpressions { get; set; }

        /// <summary>
        /// Gets or Sets CustomizeAnimationLayers
        /// </summary>
        [DataMember(Name = "customizeAnimationLayers", IsRequired = true, EmitDefaultValue = true)]
        public bool CustomizeAnimationLayers { get; set; }

        /// <summary>
        /// Gets or Sets EnableEyeLook
        /// </summary>
        [DataMember(Name = "enableEyeLook", IsRequired = true, EmitDefaultValue = true)]
        public bool EnableEyeLook { get; set; }

        /// <summary>
        /// Gets or Sets LightCount
        /// </summary>
        [DataMember(Name = "lightCount", IsRequired = true, EmitDefaultValue = true)]
        public int LightCount { get; set; }

        /// <summary>
        /// Gets or Sets LineRendererCount
        /// </summary>
        [DataMember(Name = "lineRendererCount", IsRequired = true, EmitDefaultValue = true)]
        public int LineRendererCount { get; set; }

        /// <summary>
        /// Gets or Sets LipSync
        /// </summary>
        [DataMember(Name = "lipSync", IsRequired = true, EmitDefaultValue = true)]
        public int LipSync { get; set; }

        /// <summary>
        /// Gets or Sets MaterialCount
        /// </summary>
        [DataMember(Name = "materialCount", IsRequired = true, EmitDefaultValue = true)]
        public int MaterialCount { get; set; }

        /// <summary>
        /// Gets or Sets MaterialSlotsUsed
        /// </summary>
        [DataMember(Name = "materialSlotsUsed", IsRequired = true, EmitDefaultValue = true)]
        public int MaterialSlotsUsed { get; set; }

        /// <summary>
        /// Gets or Sets MeshCount
        /// </summary>
        [DataMember(Name = "meshCount", IsRequired = true, EmitDefaultValue = true)]
        public int MeshCount { get; set; }

        /// <summary>
        /// Gets or Sets MeshIndices
        /// </summary>
        [DataMember(Name = "meshIndices", IsRequired = true, EmitDefaultValue = true)]
        public int MeshIndices { get; set; }

        /// <summary>
        /// Gets or Sets MeshParticleMaxPolygons
        /// </summary>
        [DataMember(Name = "meshParticleMaxPolygons", IsRequired = true, EmitDefaultValue = true)]
        public int MeshParticleMaxPolygons { get; set; }

        /// <summary>
        /// Gets or Sets MeshPolygons
        /// </summary>
        [DataMember(Name = "meshPolygons", IsRequired = true, EmitDefaultValue = true)]
        public int MeshPolygons { get; set; }

        /// <summary>
        /// Gets or Sets MeshVertices
        /// </summary>
        [DataMember(Name = "meshVertices", IsRequired = true, EmitDefaultValue = true)]
        public int MeshVertices { get; set; }

        /// <summary>
        /// Gets or Sets ParticleCollisionEnabled
        /// </summary>
        [DataMember(Name = "particleCollisionEnabled", IsRequired = true, EmitDefaultValue = true)]
        public bool ParticleCollisionEnabled { get; set; }

        /// <summary>
        /// Gets or Sets ParticleSystemCount
        /// </summary>
        [DataMember(Name = "particleSystemCount", IsRequired = true, EmitDefaultValue = true)]
        public int ParticleSystemCount { get; set; }

        /// <summary>
        /// Gets or Sets ParticleTrailsEnabled
        /// </summary>
        [DataMember(Name = "particleTrailsEnabled", IsRequired = true, EmitDefaultValue = true)]
        public bool ParticleTrailsEnabled { get; set; }

        /// <summary>
        /// Gets or Sets PhysBoneColliderCount
        /// </summary>
        [DataMember(Name = "physBoneColliderCount", IsRequired = true, EmitDefaultValue = true)]
        public int PhysBoneColliderCount { get; set; }

        /// <summary>
        /// Gets or Sets PhysBoneCollisionCheckCount
        /// </summary>
        [DataMember(Name = "physBoneCollisionCheckCount", IsRequired = true, EmitDefaultValue = true)]
        public int PhysBoneCollisionCheckCount { get; set; }

        /// <summary>
        /// Gets or Sets PhysBoneComponentCount
        /// </summary>
        [DataMember(Name = "physBoneComponentCount", IsRequired = true, EmitDefaultValue = true)]
        public int PhysBoneComponentCount { get; set; }

        /// <summary>
        /// Gets or Sets PhysBoneTransformCount
        /// </summary>
        [DataMember(Name = "physBoneTransformCount", IsRequired = true, EmitDefaultValue = true)]
        public int PhysBoneTransformCount { get; set; }

        /// <summary>
        /// Gets or Sets PhysicsColliders
        /// </summary>
        [DataMember(Name = "physicsColliders", IsRequired = true, EmitDefaultValue = true)]
        public int PhysicsColliders { get; set; }

        /// <summary>
        /// Gets or Sets PhysicsRigidbodies
        /// </summary>
        [DataMember(Name = "physicsRigidbodies", IsRequired = true, EmitDefaultValue = true)]
        public int PhysicsRigidbodies { get; set; }

        /// <summary>
        /// Gets or Sets SkinnedMeshCount
        /// </summary>
        [DataMember(Name = "skinnedMeshCount", IsRequired = true, EmitDefaultValue = true)]
        public int SkinnedMeshCount { get; set; }

        /// <summary>
        /// Gets or Sets SkinnedMeshIndices
        /// </summary>
        [DataMember(Name = "skinnedMeshIndices", IsRequired = true, EmitDefaultValue = true)]
        public int SkinnedMeshIndices { get; set; }

        /// <summary>
        /// Gets or Sets SkinnedMeshPolygons
        /// </summary>
        [DataMember(Name = "skinnedMeshPolygons", IsRequired = true, EmitDefaultValue = true)]
        public int SkinnedMeshPolygons { get; set; }

        /// <summary>
        /// Gets or Sets SkinnedMeshVertices
        /// </summary>
        [DataMember(Name = "skinnedMeshVertices", IsRequired = true, EmitDefaultValue = true)]
        public int SkinnedMeshVertices { get; set; }

        /// <summary>
        /// Gets or Sets TotalClothVertices
        /// </summary>
        [DataMember(Name = "totalClothVertices", IsRequired = true, EmitDefaultValue = true)]
        public int TotalClothVertices { get; set; }

        /// <summary>
        /// Gets or Sets TotalIndices
        /// </summary>
        [DataMember(Name = "totalIndices", IsRequired = true, EmitDefaultValue = true)]
        public int TotalIndices { get; set; }

        /// <summary>
        /// Gets or Sets TotalMaxParticles
        /// </summary>
        [DataMember(Name = "totalMaxParticles", IsRequired = true, EmitDefaultValue = true)]
        public int TotalMaxParticles { get; set; }

        /// <summary>
        /// Gets or Sets TotalPolygons
        /// </summary>
        [DataMember(Name = "totalPolygons", IsRequired = true, EmitDefaultValue = true)]
        public int TotalPolygons { get; set; }

        /// <summary>
        /// Gets or Sets TotalTextureUsage
        /// </summary>
        [DataMember(Name = "totalTextureUsage", IsRequired = true, EmitDefaultValue = true)]
        public int TotalTextureUsage { get; set; }

        /// <summary>
        /// Gets or Sets TotalVertices
        /// </summary>
        [DataMember(Name = "totalVertices", IsRequired = true, EmitDefaultValue = true)]
        public int TotalVertices { get; set; }

        /// <summary>
        /// Gets or Sets TrailRendererCount
        /// </summary>
        [DataMember(Name = "trailRendererCount", IsRequired = true, EmitDefaultValue = true)]
        public int TrailRendererCount { get; set; }

        /// <summary>
        /// Gets or Sets WriteDefaultsUsed
        /// </summary>
        [DataMember(Name = "writeDefaultsUsed", IsRequired = true, EmitDefaultValue = true)]
        public bool WriteDefaultsUsed { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FileAnalysisAvatarStats {\n");
            sb.Append("  AnimatorCount: ").Append(AnimatorCount).Append("\n");
            sb.Append("  AudioSourceCount: ").Append(AudioSourceCount).Append("\n");
            sb.Append("  BlendShapeCount: ").Append(BlendShapeCount).Append("\n");
            sb.Append("  BoneCount: ").Append(BoneCount).Append("\n");
            sb.Append("  Bounds: ").Append(Bounds).Append("\n");
            sb.Append("  CameraCount: ").Append(CameraCount).Append("\n");
            sb.Append("  ClothCount: ").Append(ClothCount).Append("\n");
            sb.Append("  ConstraintCount: ").Append(ConstraintCount).Append("\n");
            sb.Append("  ContactCount: ").Append(ContactCount).Append("\n");
            sb.Append("  CustomExpressions: ").Append(CustomExpressions).Append("\n");
            sb.Append("  CustomizeAnimationLayers: ").Append(CustomizeAnimationLayers).Append("\n");
            sb.Append("  EnableEyeLook: ").Append(EnableEyeLook).Append("\n");
            sb.Append("  LightCount: ").Append(LightCount).Append("\n");
            sb.Append("  LineRendererCount: ").Append(LineRendererCount).Append("\n");
            sb.Append("  LipSync: ").Append(LipSync).Append("\n");
            sb.Append("  MaterialCount: ").Append(MaterialCount).Append("\n");
            sb.Append("  MaterialSlotsUsed: ").Append(MaterialSlotsUsed).Append("\n");
            sb.Append("  MeshCount: ").Append(MeshCount).Append("\n");
            sb.Append("  MeshIndices: ").Append(MeshIndices).Append("\n");
            sb.Append("  MeshParticleMaxPolygons: ").Append(MeshParticleMaxPolygons).Append("\n");
            sb.Append("  MeshPolygons: ").Append(MeshPolygons).Append("\n");
            sb.Append("  MeshVertices: ").Append(MeshVertices).Append("\n");
            sb.Append("  ParticleCollisionEnabled: ").Append(ParticleCollisionEnabled).Append("\n");
            sb.Append("  ParticleSystemCount: ").Append(ParticleSystemCount).Append("\n");
            sb.Append("  ParticleTrailsEnabled: ").Append(ParticleTrailsEnabled).Append("\n");
            sb.Append("  PhysBoneColliderCount: ").Append(PhysBoneColliderCount).Append("\n");
            sb.Append("  PhysBoneCollisionCheckCount: ").Append(PhysBoneCollisionCheckCount).Append("\n");
            sb.Append("  PhysBoneComponentCount: ").Append(PhysBoneComponentCount).Append("\n");
            sb.Append("  PhysBoneTransformCount: ").Append(PhysBoneTransformCount).Append("\n");
            sb.Append("  PhysicsColliders: ").Append(PhysicsColliders).Append("\n");
            sb.Append("  PhysicsRigidbodies: ").Append(PhysicsRigidbodies).Append("\n");
            sb.Append("  SkinnedMeshCount: ").Append(SkinnedMeshCount).Append("\n");
            sb.Append("  SkinnedMeshIndices: ").Append(SkinnedMeshIndices).Append("\n");
            sb.Append("  SkinnedMeshPolygons: ").Append(SkinnedMeshPolygons).Append("\n");
            sb.Append("  SkinnedMeshVertices: ").Append(SkinnedMeshVertices).Append("\n");
            sb.Append("  TotalClothVertices: ").Append(TotalClothVertices).Append("\n");
            sb.Append("  TotalIndices: ").Append(TotalIndices).Append("\n");
            sb.Append("  TotalMaxParticles: ").Append(TotalMaxParticles).Append("\n");
            sb.Append("  TotalPolygons: ").Append(TotalPolygons).Append("\n");
            sb.Append("  TotalTextureUsage: ").Append(TotalTextureUsage).Append("\n");
            sb.Append("  TotalVertices: ").Append(TotalVertices).Append("\n");
            sb.Append("  TrailRendererCount: ").Append(TrailRendererCount).Append("\n");
            sb.Append("  WriteDefaultsUsed: ").Append(WriteDefaultsUsed).Append("\n");
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
            return this.Equals(input as FileAnalysisAvatarStats);
        }

        /// <summary>
        /// Returns true if FileAnalysisAvatarStats instances are equal
        /// </summary>
        /// <param name="input">Instance of FileAnalysisAvatarStats to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FileAnalysisAvatarStats input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AnimatorCount == input.AnimatorCount ||
                    this.AnimatorCount.Equals(input.AnimatorCount)
                ) && 
                (
                    this.AudioSourceCount == input.AudioSourceCount ||
                    this.AudioSourceCount.Equals(input.AudioSourceCount)
                ) && 
                (
                    this.BlendShapeCount == input.BlendShapeCount ||
                    this.BlendShapeCount.Equals(input.BlendShapeCount)
                ) && 
                (
                    this.BoneCount == input.BoneCount ||
                    this.BoneCount.Equals(input.BoneCount)
                ) && 
                (
                    this.Bounds == input.Bounds ||
                    this.Bounds != null &&
                    input.Bounds != null &&
                    this.Bounds.SequenceEqual(input.Bounds)
                ) && 
                (
                    this.CameraCount == input.CameraCount ||
                    this.CameraCount.Equals(input.CameraCount)
                ) && 
                (
                    this.ClothCount == input.ClothCount ||
                    this.ClothCount.Equals(input.ClothCount)
                ) && 
                (
                    this.ConstraintCount == input.ConstraintCount ||
                    this.ConstraintCount.Equals(input.ConstraintCount)
                ) && 
                (
                    this.ContactCount == input.ContactCount ||
                    this.ContactCount.Equals(input.ContactCount)
                ) && 
                (
                    this.CustomExpressions == input.CustomExpressions ||
                    this.CustomExpressions.Equals(input.CustomExpressions)
                ) && 
                (
                    this.CustomizeAnimationLayers == input.CustomizeAnimationLayers ||
                    this.CustomizeAnimationLayers.Equals(input.CustomizeAnimationLayers)
                ) && 
                (
                    this.EnableEyeLook == input.EnableEyeLook ||
                    this.EnableEyeLook.Equals(input.EnableEyeLook)
                ) && 
                (
                    this.LightCount == input.LightCount ||
                    this.LightCount.Equals(input.LightCount)
                ) && 
                (
                    this.LineRendererCount == input.LineRendererCount ||
                    this.LineRendererCount.Equals(input.LineRendererCount)
                ) && 
                (
                    this.LipSync == input.LipSync ||
                    this.LipSync.Equals(input.LipSync)
                ) && 
                (
                    this.MaterialCount == input.MaterialCount ||
                    this.MaterialCount.Equals(input.MaterialCount)
                ) && 
                (
                    this.MaterialSlotsUsed == input.MaterialSlotsUsed ||
                    this.MaterialSlotsUsed.Equals(input.MaterialSlotsUsed)
                ) && 
                (
                    this.MeshCount == input.MeshCount ||
                    this.MeshCount.Equals(input.MeshCount)
                ) && 
                (
                    this.MeshIndices == input.MeshIndices ||
                    this.MeshIndices.Equals(input.MeshIndices)
                ) && 
                (
                    this.MeshParticleMaxPolygons == input.MeshParticleMaxPolygons ||
                    this.MeshParticleMaxPolygons.Equals(input.MeshParticleMaxPolygons)
                ) && 
                (
                    this.MeshPolygons == input.MeshPolygons ||
                    this.MeshPolygons.Equals(input.MeshPolygons)
                ) && 
                (
                    this.MeshVertices == input.MeshVertices ||
                    this.MeshVertices.Equals(input.MeshVertices)
                ) && 
                (
                    this.ParticleCollisionEnabled == input.ParticleCollisionEnabled ||
                    this.ParticleCollisionEnabled.Equals(input.ParticleCollisionEnabled)
                ) && 
                (
                    this.ParticleSystemCount == input.ParticleSystemCount ||
                    this.ParticleSystemCount.Equals(input.ParticleSystemCount)
                ) && 
                (
                    this.ParticleTrailsEnabled == input.ParticleTrailsEnabled ||
                    this.ParticleTrailsEnabled.Equals(input.ParticleTrailsEnabled)
                ) && 
                (
                    this.PhysBoneColliderCount == input.PhysBoneColliderCount ||
                    this.PhysBoneColliderCount.Equals(input.PhysBoneColliderCount)
                ) && 
                (
                    this.PhysBoneCollisionCheckCount == input.PhysBoneCollisionCheckCount ||
                    this.PhysBoneCollisionCheckCount.Equals(input.PhysBoneCollisionCheckCount)
                ) && 
                (
                    this.PhysBoneComponentCount == input.PhysBoneComponentCount ||
                    this.PhysBoneComponentCount.Equals(input.PhysBoneComponentCount)
                ) && 
                (
                    this.PhysBoneTransformCount == input.PhysBoneTransformCount ||
                    this.PhysBoneTransformCount.Equals(input.PhysBoneTransformCount)
                ) && 
                (
                    this.PhysicsColliders == input.PhysicsColliders ||
                    this.PhysicsColliders.Equals(input.PhysicsColliders)
                ) && 
                (
                    this.PhysicsRigidbodies == input.PhysicsRigidbodies ||
                    this.PhysicsRigidbodies.Equals(input.PhysicsRigidbodies)
                ) && 
                (
                    this.SkinnedMeshCount == input.SkinnedMeshCount ||
                    this.SkinnedMeshCount.Equals(input.SkinnedMeshCount)
                ) && 
                (
                    this.SkinnedMeshIndices == input.SkinnedMeshIndices ||
                    this.SkinnedMeshIndices.Equals(input.SkinnedMeshIndices)
                ) && 
                (
                    this.SkinnedMeshPolygons == input.SkinnedMeshPolygons ||
                    this.SkinnedMeshPolygons.Equals(input.SkinnedMeshPolygons)
                ) && 
                (
                    this.SkinnedMeshVertices == input.SkinnedMeshVertices ||
                    this.SkinnedMeshVertices.Equals(input.SkinnedMeshVertices)
                ) && 
                (
                    this.TotalClothVertices == input.TotalClothVertices ||
                    this.TotalClothVertices.Equals(input.TotalClothVertices)
                ) && 
                (
                    this.TotalIndices == input.TotalIndices ||
                    this.TotalIndices.Equals(input.TotalIndices)
                ) && 
                (
                    this.TotalMaxParticles == input.TotalMaxParticles ||
                    this.TotalMaxParticles.Equals(input.TotalMaxParticles)
                ) && 
                (
                    this.TotalPolygons == input.TotalPolygons ||
                    this.TotalPolygons.Equals(input.TotalPolygons)
                ) && 
                (
                    this.TotalTextureUsage == input.TotalTextureUsage ||
                    this.TotalTextureUsage.Equals(input.TotalTextureUsage)
                ) && 
                (
                    this.TotalVertices == input.TotalVertices ||
                    this.TotalVertices.Equals(input.TotalVertices)
                ) && 
                (
                    this.TrailRendererCount == input.TrailRendererCount ||
                    this.TrailRendererCount.Equals(input.TrailRendererCount)
                ) && 
                (
                    this.WriteDefaultsUsed == input.WriteDefaultsUsed ||
                    this.WriteDefaultsUsed.Equals(input.WriteDefaultsUsed)
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
                hashCode = (hashCode * 59) + this.AnimatorCount.GetHashCode();
                hashCode = (hashCode * 59) + this.AudioSourceCount.GetHashCode();
                hashCode = (hashCode * 59) + this.BlendShapeCount.GetHashCode();
                hashCode = (hashCode * 59) + this.BoneCount.GetHashCode();
                if (this.Bounds != null)
                {
                    hashCode = (hashCode * 59) + this.Bounds.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CameraCount.GetHashCode();
                hashCode = (hashCode * 59) + this.ClothCount.GetHashCode();
                hashCode = (hashCode * 59) + this.ConstraintCount.GetHashCode();
                hashCode = (hashCode * 59) + this.ContactCount.GetHashCode();
                hashCode = (hashCode * 59) + this.CustomExpressions.GetHashCode();
                hashCode = (hashCode * 59) + this.CustomizeAnimationLayers.GetHashCode();
                hashCode = (hashCode * 59) + this.EnableEyeLook.GetHashCode();
                hashCode = (hashCode * 59) + this.LightCount.GetHashCode();
                hashCode = (hashCode * 59) + this.LineRendererCount.GetHashCode();
                hashCode = (hashCode * 59) + this.LipSync.GetHashCode();
                hashCode = (hashCode * 59) + this.MaterialCount.GetHashCode();
                hashCode = (hashCode * 59) + this.MaterialSlotsUsed.GetHashCode();
                hashCode = (hashCode * 59) + this.MeshCount.GetHashCode();
                hashCode = (hashCode * 59) + this.MeshIndices.GetHashCode();
                hashCode = (hashCode * 59) + this.MeshParticleMaxPolygons.GetHashCode();
                hashCode = (hashCode * 59) + this.MeshPolygons.GetHashCode();
                hashCode = (hashCode * 59) + this.MeshVertices.GetHashCode();
                hashCode = (hashCode * 59) + this.ParticleCollisionEnabled.GetHashCode();
                hashCode = (hashCode * 59) + this.ParticleSystemCount.GetHashCode();
                hashCode = (hashCode * 59) + this.ParticleTrailsEnabled.GetHashCode();
                hashCode = (hashCode * 59) + this.PhysBoneColliderCount.GetHashCode();
                hashCode = (hashCode * 59) + this.PhysBoneCollisionCheckCount.GetHashCode();
                hashCode = (hashCode * 59) + this.PhysBoneComponentCount.GetHashCode();
                hashCode = (hashCode * 59) + this.PhysBoneTransformCount.GetHashCode();
                hashCode = (hashCode * 59) + this.PhysicsColliders.GetHashCode();
                hashCode = (hashCode * 59) + this.PhysicsRigidbodies.GetHashCode();
                hashCode = (hashCode * 59) + this.SkinnedMeshCount.GetHashCode();
                hashCode = (hashCode * 59) + this.SkinnedMeshIndices.GetHashCode();
                hashCode = (hashCode * 59) + this.SkinnedMeshPolygons.GetHashCode();
                hashCode = (hashCode * 59) + this.SkinnedMeshVertices.GetHashCode();
                hashCode = (hashCode * 59) + this.TotalClothVertices.GetHashCode();
                hashCode = (hashCode * 59) + this.TotalIndices.GetHashCode();
                hashCode = (hashCode * 59) + this.TotalMaxParticles.GetHashCode();
                hashCode = (hashCode * 59) + this.TotalPolygons.GetHashCode();
                hashCode = (hashCode * 59) + this.TotalTextureUsage.GetHashCode();
                hashCode = (hashCode * 59) + this.TotalVertices.GetHashCode();
                hashCode = (hashCode * 59) + this.TrailRendererCount.GetHashCode();
                hashCode = (hashCode * 59) + this.WriteDefaultsUsed.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
