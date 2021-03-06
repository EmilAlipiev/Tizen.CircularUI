﻿/*
 * Copyright (c) 2018 Samsung Electronics Co., Ltd All Rights Reserved
 *
 * Licensed under the Flora License, Version 1.1 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://floralicense.org/license/
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using Xamarin.Forms;

namespace Tizen.Wearable.CircularUI.Forms
{
    /// <summary>
    /// The IInformationPopup is an interface to describe information pop-up which has circular bottom button, title, text, and content area
    /// </summary>
    internal interface IInformationPopup
    {
        /// <summary>
        /// Occurs when the Back button is pressed.
        /// </summary>
        event EventHandler BackButtonPressed;

        /// <summary>
        /// Gets or sets progress visibility of the Popup.
        /// </summary>
        bool IsProgressRunning { get; set; }

        /// <summary>
        /// Gets or sets bottom button of the Popup
        /// </summary>
        MenuItem BottomButton { get; set; }

        /// <summary>
        /// Gets or sets title of the Popup
        /// </summary>
        string Title { get; set; }

        /// <summary>
        /// Gets or sets text of the Popup
        /// </summary>
        string Text { get; set; }

        /// <summary>
        /// Shows the Popup
        /// </summary>
        void Show();

        /// <summary>
        /// Dismisses the Popup
        /// </summary>
        void Dismiss();
    }
}
