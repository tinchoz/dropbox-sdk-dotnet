// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Sharing
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>Arguments for <see
    /// cref="Dropbox.Api.Sharing.Routes.SharingUserRoutes.UpdateFileMemberAsync" />.</para>
    /// </summary>
    /// <seealso cref="Dropbox.Api.Sharing.ChangeFileMemberAccessArgs" />
    public class UpdateFileMemberArgs : ChangeFileMemberAccessArgs
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<UpdateFileMemberArgs> Encoder = new UpdateFileMemberArgsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<UpdateFileMemberArgs> Decoder = new UpdateFileMemberArgsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="UpdateFileMemberArgs" />
        /// class.</para>
        /// </summary>
        /// <param name="file">File for which we are changing a member's access.</param>
        /// <param name="member">The member whose access we are changing.</param>
        /// <param name="accessLevel">The new access level for the member.</param>
        public UpdateFileMemberArgs(string file,
                                    MemberSelector member,
                                    AccessLevel accessLevel)
            : base(file, member, accessLevel)
        {
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="UpdateFileMemberArgs" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public UpdateFileMemberArgs()
        {
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="UpdateFileMemberArgs" />.</para>
        /// </summary>
        private class UpdateFileMemberArgsEncoder : enc.StructEncoder<UpdateFileMemberArgs>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(UpdateFileMemberArgs value, enc.IJsonWriter writer)
            {
                WriteProperty("file", value.File, writer, enc.StringEncoder.Instance);
                WriteProperty("member", value.Member, writer, Dropbox.Api.Sharing.MemberSelector.Encoder);
                WriteProperty("access_level", value.AccessLevel, writer, Dropbox.Api.Sharing.AccessLevel.Encoder);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="UpdateFileMemberArgs" />.</para>
        /// </summary>
        private class UpdateFileMemberArgsDecoder : enc.StructDecoder<UpdateFileMemberArgs>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="UpdateFileMemberArgs" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override UpdateFileMemberArgs Create()
            {
                return new UpdateFileMemberArgs();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(UpdateFileMemberArgs value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "file":
                        value.File = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "member":
                        value.Member = Dropbox.Api.Sharing.MemberSelector.Decoder.Decode(reader);
                        break;
                    case "access_level":
                        value.AccessLevel = Dropbox.Api.Sharing.AccessLevel.Decoder.Decode(reader);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}
