// Copyright 2020 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

using gax = Google.Api.Gax;
using gcfav = Google.Cloud.Firestore.Admin.V1;
using sys = System;

namespace Google.Cloud.Firestore.Admin.V1
{
    /// <summary>Resource name for the <c>Index</c> resource.</summary>
    public sealed partial class IndexName : gax::IResourceName, sys::IEquatable<IndexName>
    {
        /// <summary>The possible contents of <see cref="IndexName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/databases/{database}/collectionGroups/{collection}/indexes/{index}</c>.
            /// </summary>
            ProjectDatabaseCollectionIndex = 1
        }

        private static gax::PathTemplate s_projectDatabaseCollectionIndex = new gax::PathTemplate("projects/{project}/databases/{database}/collectionGroups/{collection}/indexes/{index}");

        /// <summary>Creates a <see cref="IndexName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="IndexName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static IndexName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new IndexName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="IndexName"/> with the pattern
        /// <c>projects/{project}/databases/{database}/collectionGroups/{collection}/indexes/{index}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="databaseId">The <c>Database</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="collectionId">The <c>Collection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="indexId">The <c>Index</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="IndexName"/> constructed from the provided ids.</returns>
        public static IndexName FromProjectDatabaseCollectionIndex(string projectId, string databaseId, string collectionId, string indexId) =>
            new IndexName(ResourceNameType.ProjectDatabaseCollectionIndex, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), databaseId: gax::GaxPreconditions.CheckNotNullOrEmpty(databaseId, nameof(databaseId)), collectionId: gax::GaxPreconditions.CheckNotNullOrEmpty(collectionId, nameof(collectionId)), indexId: gax::GaxPreconditions.CheckNotNullOrEmpty(indexId, nameof(indexId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="IndexName"/> with pattern
        /// <c>projects/{project}/databases/{database}/collectionGroups/{collection}/indexes/{index}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="databaseId">The <c>Database</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="collectionId">The <c>Collection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="indexId">The <c>Index</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="IndexName"/> with pattern
        /// <c>projects/{project}/databases/{database}/collectionGroups/{collection}/indexes/{index}</c>.
        /// </returns>
        public static string Format(string projectId, string databaseId, string collectionId, string indexId) =>
            FormatProjectDatabaseCollectionIndex(projectId, databaseId, collectionId, indexId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="IndexName"/> with pattern
        /// <c>projects/{project}/databases/{database}/collectionGroups/{collection}/indexes/{index}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="databaseId">The <c>Database</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="collectionId">The <c>Collection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="indexId">The <c>Index</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="IndexName"/> with pattern
        /// <c>projects/{project}/databases/{database}/collectionGroups/{collection}/indexes/{index}</c>.
        /// </returns>
        public static string FormatProjectDatabaseCollectionIndex(string projectId, string databaseId, string collectionId, string indexId) =>
            s_projectDatabaseCollectionIndex.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(databaseId, nameof(databaseId)), gax::GaxPreconditions.CheckNotNullOrEmpty(collectionId, nameof(collectionId)), gax::GaxPreconditions.CheckNotNullOrEmpty(indexId, nameof(indexId)));

        /// <summary>Parses the given resource name string into a new <see cref="IndexName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/databases/{database}/collectionGroups/{collection}/indexes/{index}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="indexName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="IndexName"/> if successful.</returns>
        public static IndexName Parse(string indexName) => Parse(indexName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="IndexName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/databases/{database}/collectionGroups/{collection}/indexes/{index}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="indexName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="IndexName"/> if successful.</returns>
        public static IndexName Parse(string indexName, bool allowUnparsed) =>
            TryParse(indexName, allowUnparsed, out IndexName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="IndexName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/databases/{database}/collectionGroups/{collection}/indexes/{index}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="indexName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="IndexName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string indexName, out IndexName result) => TryParse(indexName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="IndexName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/databases/{database}/collectionGroups/{collection}/indexes/{index}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="indexName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="IndexName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string indexName, bool allowUnparsed, out IndexName result)
        {
            gax::GaxPreconditions.CheckNotNull(indexName, nameof(indexName));
            gax::TemplatedResourceName resourceName;
            if (s_projectDatabaseCollectionIndex.TryParseName(indexName, out resourceName))
            {
                result = FromProjectDatabaseCollectionIndex(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(indexName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private IndexName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string collectionId = null, string databaseId = null, string indexId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CollectionId = collectionId;
            DatabaseId = databaseId;
            IndexId = indexId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="IndexName"/> class from the component parts of pattern
        /// <c>projects/{project}/databases/{database}/collectionGroups/{collection}/indexes/{index}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="databaseId">The <c>Database</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="collectionId">The <c>Collection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="indexId">The <c>Index</c> ID. Must not be <c>null</c> or empty.</param>
        public IndexName(string projectId, string databaseId, string collectionId, string indexId) : this(ResourceNameType.ProjectDatabaseCollectionIndex, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), databaseId: gax::GaxPreconditions.CheckNotNullOrEmpty(databaseId, nameof(databaseId)), collectionId: gax::GaxPreconditions.CheckNotNullOrEmpty(collectionId, nameof(collectionId)), indexId: gax::GaxPreconditions.CheckNotNullOrEmpty(indexId, nameof(indexId)))
        {
        }

        /// <summary>The <see cref="ResourceNameType"/> of the contained resource name.</summary>
        public ResourceNameType Type { get; }

        /// <summary>
        /// The contained <see cref="gax::UnparsedResourceName"/>. Only non-<c>null</c>if this instance contains an
        /// unparsed resource name.
        /// </summary>
        public gax::UnparsedResourceName UnparsedResource { get; }

        /// <summary>
        /// The <c>Collection</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string CollectionId { get; }

        /// <summary>
        /// The <c>Database</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string DatabaseId { get; }

        /// <summary>
        /// The <c>Index</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string IndexId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <inheritdoc/>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <inheritdoc/>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectDatabaseCollectionIndex: return s_projectDatabaseCollectionIndex.Expand(ProjectId, DatabaseId, CollectionId, IndexId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <inheritdoc/>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as IndexName);

        /// <inheritdoc/>
        public bool Equals(IndexName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(IndexName a, IndexName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(IndexName a, IndexName b) => !(a == b);
    }

    public partial class Index
    {
        /// <summary>
        /// <see cref="gcfav::IndexName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcfav::IndexName IndexName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcfav::IndexName.Parse(Name);
            set => Name = value?.ToString() ?? "";
        }
    }
}
