# WinChess

A C# WinForms chess game targeting .NET Framework 4.7.2. Features modern UI, timers, avatars, audio cues, and move-highlighting to make casual chess games more engaging on Windows.

---

## Overview

WinChess is a desktop chess application built with WinForms (.NET Framework 4.7.2). It implements full legal move generation and common chess rules including castling, en passant and pawn promotion. The UI includes turn timers, possible-move highlights, avatar selection, and audio feedback for moves, captures and game end.

Screenshots:
- (placeholder) ![Screenshot - Main Board](docs/screenshots/main-board.png)
- (placeholder) ![Screenshot - Avatar Picker](docs/screenshots/avatar-picker.png)
- (placeholder) ![Screenshot - Settings / Music](docs/screenshots/settings-music.png)

Replace the placeholders above with actual images in `docs/screenshots/`.

---

## Features

- Full legal move generation and validation
- Check and checkmate detection
- Castling (king and rook movement rules)
- En passant captures
- Pawn promotion with selection UI
- Undo last move
- Per-player turn timer (start/stop)
- Highlights for possible moves
- Avatar picker for players
- Audio cues:
  - move (move-self.wav)
  - capture (capture-self.wav)
  - checkmate / game end (koto.wav)
- Background music (Carefree.wav) with toggle

---

## Usage

- Start / Stop Timer: Use the timer controls on the main window to start or pause the turn timers.
- Undo / Restart: Use the Undo button to revert the last move. Use the Restart/New Game action to reset the board.
- Select Avatars: Open the Avatar picker to choose avatars for each player.
- Toggle Music: Use the music toggle to play/pause background music. Note: See Known Limitations about the current hardcoded music path.

---

## Build & Run

Requirements:
- Windows (WinForms / Windows-only dependencies)
- Visual Studio 2022 (recommended) with .NET Framework 4.7.2 workload

Steps:
1. Clone the repository:
   git clone https://github.com/Sho-jii/WinChess.git
2. Open `WinChess.sln` in Visual Studio 2022.
3. Restore NuGet packages (Visual Studio will prompt or use `Restore NuGet Packages`).
4. Build the solution.
5. Run the project (Start Debugging or Start Without Debugging).

---

## Project Structure (key files)

- ChessWindow.cs
  - Main UI, timers, music controls and top-level event wiring.
  - Note: currently contains a hardcoded path to Carefree.wav (see Known Limitations).
- Board.cs
  - Board state representation, piece placement and board-level helpers.
- Movement.cs
  - Move generation and validation logic, rules enforcement (castling, en passant, promotion).
- Tile.cs
  - Individual tile representation and UI wrapper logic.
- PieceSelection.cs
  - Pawn promotion UI and piece choice handling.
- AvatarSelection.cs
  - Avatar selection UI and avatar asset loading.
- Program.cs
  - Application entry point.

---

## Dependencies

- Guna.UI2.WinForms 2.0.4.6
- MetroFramework (UI theming)
- ReaLTaiizor (UI components)
- Newtonsoft.Json 13.0.3 (for any persisted settings / assets metadata)
- Windows Media Player COM (AxWMPLib / WMPLib) for audio playback

Ensure these are restored by NuGet (or installed/registered for COM) prior to building.

---

## Assets

Included assets (example filenames):
- Chess piece images (in Assets/ or Resources/)
- Avatar images (in Assets/avatars/)
- Sounds:
  - capture-self.wav
  - move-self.wav
  - koto.wav
- Background music:
  - Carefree.wav

Note: The current implementation references a hardcoded absolute path to `Carefree.wav` in `ChessWindow.cs`. For portability it's recommended to:
- Embed the audio file as a project resource (Properties → Resources) and play from resources, or
- Store assets with relative paths inside the application directory and use an application-level configuration or settings file to locate them.

---

## Known Limitations / Notes

- Carefree.wav path is currently hardcoded in ChessWindow.cs — this makes the music feature brittle. Prefer embedding or configurable relative paths.
- Windows-only: relies on WinForms and Windows Media Player COM components.
- No network play or online multiplayer implemented.
- No strong AI opponent included (human vs human by default).
- Some UI components rely on third-party WinForms libraries (see Dependencies) — ensure compatible versions are installed.

---

## Roadmap

Planned improvements and ideas:
- Make asset and audio paths configurable via UI or settings file.
- Move audio files into application Resources (embed) or use relative asset loading for portability.
- Add AI opponent (local engine) and difficulty settings.
- PGN export/import support (save/load games and move history).
- Add detailed settings screen (audio volume, timer defaults, UI themes).
- Add online play / lobby (future networked play).
- Add test coverage for Movement/Board logic.

---

## License

This project is recommended to be licensed under the MIT License. Add a top-level `LICENSE` file with the MIT template if you approve.

Example short notice:
MIT License — see LICENSE file for details.

---

## Third-party Notices

- Newtonsoft.Json (Json.NET) — MIT License
- Guna.UI2.WinForms — verify vendor license (commercial vs free tiers may apply)
- MetroFramework — check license in project (typically MIT or MS-PL variants)
- ReaLTaiizor — check vendor license
- Windows Media Player COM components — part of Windows; follow Windows runtime licensing/redistribution rules

If you redistribute third-party libraries or ship binaries, include the appropriate notices and license texts for those libraries in a `THIRD-PARTY-NOTICES.md` or similar.

---

## Contributing

Contributions welcome. Suggested workflow:
1. Fork the repo
2. Create a branch for your feature/fix
3. Open a PR with a clear description and tests where applicable

---

If you'd like, I can:
- Add the LICENSE and THIRD-PARTY-NOTICES files,
- Replace the hardcoded music path in ChessWindow.cs with a Resources-based approach,
- Or open a PR that implements configurable asset paths and moves the music into project resources.
