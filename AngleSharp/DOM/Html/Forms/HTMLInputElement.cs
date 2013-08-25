﻿using System;

namespace AngleSharp.DOM.Html
{
    /// <summary>
    /// Represents an HTML input element.
    /// </summary>
    [DOM("HTMLInputElement")]
    public sealed class HTMLInputElement : HTMLTextFormControlElement
    {
        #region Constant

        /// <summary>
        /// The input tag.
        /// </summary>
        internal const String Tag = "input";

        #endregion

        #region ctor

        /// <summary>
        /// Creates a new HTML input element.
        /// </summary>
        internal HTMLInputElement()
        {
            _name = Tag;
            WillValidate = true;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets if the input element is checked or not.
        /// </summary>
        [DOM("checked")]
        public Boolean Checked
        {
            get { return GetAttribute("checked") != null; }
            set { SetAttribute("checked", value ? String.Empty : null); }
        }

        /// <summary>
        /// Gets or sets the type of the input field.
        /// </summary>
        [DOM("type")]
        public InputType Type
        {
            get { return ToEnum(GetAttribute("type"), InputType.Text); }
            set { SetAttribute("type", value.ToString()); }
        }

        /// <summary>
        /// Gets or sets if the state if indeterminate.
        /// </summary>
        [DOM("indeterminate")]
        public Boolean Indeterminate 
        { 
            get; 
            set; 
        }

        #endregion

        #region Design properties

        /// <summary>
        /// Gets or sets if the link has been visited.
        /// </summary>
        internal Boolean IsVisited
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets if the link is currently active.
        /// </summary>
        internal Boolean IsActive
        {
            get;
            set;
        }

        #endregion

        #region Methods

        #endregion

        #region Internal Properties

        internal Boolean IsMutable 
        {
            get { return !Disabled && !Readonly; }
        }

        /// <summary>
        /// Gets if the node is in the special category.
        /// </summary>
        protected internal override Boolean IsSpecial
        {
            get { return true; }
        }

        #endregion

        #region Enumeration

        /// <summary>
        /// An enumeration with possible input types.
        /// </summary>
        public enum InputType : ushort
        {
            /// <summary>
            /// The input will be hidden.
            /// </summary>
            Hidden,
            /// <summary>
            /// A standard (1-line) text input.
            /// </summary>
            Text,
            /// <summary>
            /// A search input.
            /// </summary>
            Search,
            /// <summary>
            /// A telephone number input.
            /// </summary>
            Tel,
            /// <summary>
            /// An URL input field.
            /// </summary>
            Url,
            /// <summary>
            /// An email input field.
            /// </summary>
            Email,
            /// <summary>
            /// A password input field.
            /// </summary>
            Password,
            /// <summary>
            /// A datetime input field.
            /// </summary>
            Datetime,
            /// <summary>
            /// A date input field.
            /// </summary>
            Date,
            /// <summary>
            /// A month picker input field.
            /// </summary>
            Month,
            /// <summary>
            /// A week picker input field.
            /// </summary>
            Week,
            /// <summary>
            /// A time picker input field.
            /// </summary>
            Time,
            /// <summary>
            /// A number input field.
            /// </summary>
            Number,
            /// <summary>
            /// A range picker.
            /// </summary>
            Range,
            /// <summary>
            /// A color picker input field.
            /// </summary>
            Color,
            /// <summary>
            /// A checkbox.
            /// </summary>
            Checkbox,
            /// <summary>
            /// A radio box.
            /// </summary>
            Radio,
            /// <summary>
            /// A file upload box.
            /// </summary>
            File,
            /// <summary>
            /// A submit button.
            /// </summary>
            Submit,
            /// <summary>
            /// An image input box.
            /// </summary>
            Image,
            /// <summary>
            /// A reset form button.
            /// </summary>
            Reset,
            /// <summary>
            /// A simple button.
            /// </summary>
            Button
        }

        #endregion

        #region Helpers

        /// <summary>
        /// Resets the form control to its initial value.
        /// </summary>
        internal override void Reset()
        {
            //TODO
        }

        /// <summary>
        /// Checks the form control for validity.
        /// </summary>
        /// <param name="state">The element's validity state tracker.</param>
        protected override void Check(ValidityState state)
        {
            //TODO
        }

        #endregion
    }
}
