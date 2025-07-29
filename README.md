# CustomFormStyler (TitleBarManager)

A lightweight helper that replaces WinForms’ classic window chrome with a **flat, theme‑able title‑bar, rounded corners, and fully‑custom minimise / maximise / close buttons**. Drop it into any `Form`, call one line of code, and instantly modernise your UI.

- Part of **Core Keepers Workshop** and released under **GNU GPL v3**.

![CustomGUIUpdateRaw](https://github.com/user-attachments/assets/af62700a-807c-40a3-aabc-e5c669be9049)

---

## ✨ Key Features

| Feature                       | Details                                                                                                               |
|-------------------------------|-----------------------------------------------------------------------------------------------------------------------|
| **Flat Title‑Bar**            | Removes the native chrome and draws a sleek, minimal bar that blends with your app theme.                             |
| **Dark / Light Themes**       | One‑liner switch between dark and light palettes.                                                                     |
| **Rounded Corners**           | Pick any combination (`Corner` flag enum) and radius—independent of OS support.                                       |
| **Custom Buttons**            | Built‑in Min, Max, Close _(and optional Help)_ buttons with glyphs you can restyle.                                   |
| **Border Options**            | Draw borders _inside_ (**Grow In**) or _outside_ (**Grow Out**) of the client area; choose size & colour.             |
| **Runtime Updates**           | Call `UpdateStyle(...)` to tweak theme, radius, border, etc. without recreation.                                      |
| **Drag Anywhere**             | Drag the window by the custom bar—implemented via a tiny Win32 interop helper.                                        |
| **Extension Helpers**         | `Form.ApplyTheme()` & `RefreshAllThemes()` wire everything up and keep multiple windows in sync.                      |

---

## 📥 Installation
1. Copy **`TitleBarManager.cs`** (or rename) into your WinForms project.
2. Change the namespace if necessary.
3. Re‑build; no designer support is needed—the styler is code‑only.

> ℹ️ No NuGet package (yet) – just a single self‑contained file.

---

## 🚀 Quick Start

```csharp
public partial class MainForm : Form
{
    private CustomFormStyler _styler;

    public MainForm()
    {
        InitializeComponent();

        _styler = new CustomFormStyler(this);
        _styler.Enable(); // Apply the custom chrome.
    }
}
```

### The One‑liner Extension

```csharp
// Using the helper in FormStylingExtensions:
Load += (_, __) => this.ApplyTheme();
```

---

## 🛠️ Public API (Core Class)

| Member                   | Description                                                                               |
|--------------------------|-------------------------------------------------------------------------------------------|
| `Enable()` / `Disable()` | Replace or restore the native window chrome.                                              |
| `Toggle()`               | Convenience wrapper that flips the state.                                                 |
| `IsEnabled`              | `bool` – current state of the styler.                                                     |
| `UpdateStyle(...)`       | Change any subset of options at runtime (theme, border size, radius, etc.).               |
| `CloseButtonPressed`     | `bool` – becomes `true` the moment the user presses Close (handy for confirmation logic). |

### Style Parameters

| Parameter (UpdateStyle) | Type         | Notes                                           |
|-------------------------|--------------|-------------------------------------------------|
| `theme`                 | `ThemeMode`  | `Dark` / `Light`.                               |
| `borderMode`            | `BorderMode` | `GrowOut` (outside) or `GrowIn` (inside).       |
| `roundedCorners`        | `Corner`     | Flag enum (`TopLeft`, `BottomRight`, … `All`).  |
| `borderColor`           | `Color?`     | `null` ➜ auto (white on dark, black on light). |
| `titleBarHeight`        | `int`        | Pixel height of the bar.                        |
| `cornerRadius`          | `int`        | Radius in pixels. 0 ➜ square.                  |
| `borderSize`            | `int`        | Stroke width in pixels. 0 ➜ no border.         |
| `showIcon`              | `bool`       | Show/hide the small window icon.                |

---

## 🎨 Theming & Styling Tips

* **Change theme at runtime** – flip a checkbox, then call `RefreshAllThemes()` to apply the new dark/light palette across every open window.
* **Per‑window overrides** – call `UpdateStyle()` on a specific styler to deviate from global settings.
* **Help button behaviour** – if your form’s `HelpButton` property is `true` _and_ both maximise & minimise are hidden, a “?” glyph appears automatically.
* **Corner selection UI** – expose four checkboxes and build a `Corner` mask on the fly (see `MainForm.SelectedCorners`).
* **Border insets** – remember: `GrowOut` changes overall form size, while `GrowIn` eats into the client area; pick what suits your layout.

---

## ⚙️ How It Works (Under the Hood)

1. **`FormBorderStyle = None`** – strips the OS frame so we get a blank canvas.
2. **Client‑area expansion** – compensates for the new title‑bar height (and optional GrowOut border) to keep your existing controls untouched.
3. **Wrapper panel** – all pre‑existing controls are moved into a `_contentPanel` so resizing the bar never upsets user content.
4. **Drag support** – a quick call to `ReleaseCapture()` + `SendMessage(WM_NCLBUTTONDOWN, HTCAPTION)` makes the new bar draggable.
5. **Rounded corners** – `GraphicsPath` + `Region` let us clip the rectangle to any combination of rounded edges.
6. **Custom border paint** – drawn in `Form_Paint`; half‑pixel offsets ensure crisp strokes at any width.

---

## 📝 License

`TitleBarManager.cs` / `CustomFormStyler` is licensed under **GNU General Public License v3.0**.  
See the root `LICENSE` file for the full text.

---

## 🙏 Credits

Original author: **RussDev7**  
Inspired by countless WinForms custom‑chrome experiments shared by the community.

---

## 📷 Screenshots

![RoundedFormsExample](https://github.com/user-attachments/assets/e597cf53-7532-4eb6-8353-b939d383d198)

---

> Found a bug or have an idea? Open an issue or pull request—contributions welcome!

