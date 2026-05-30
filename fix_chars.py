# -*- coding: utf-8 -*-
"""
Fix garbled (mojibake) characters in index.html.
These were caused by UTF-8 text being read as Windows-1252 and then re-saved as UTF-8,
resulting in multi-character sequences instead of the intended single Unicode characters.
"""

import re

INPUT_FILE  = "index.html"
OUTPUT_FILE = "index.html"

with open(INPUT_FILE, encoding="utf-8") as f:
    content = f.read()

replacements = [
    # ── Navigation / UI symbols ──────────────────────────────────────────────
    ("â–¾",  "▾"),     # U+25BE  Black Down-Pointing Small Triangle (dropdown)
    ("â†—",  "↗"),     # U+2197  North East Arrow  (Klik untuk memperbesar)
    ("â†"  + "\u0090", "←"),  # U+2190 Left Arrow (cert button) + ctrl char
    ("â†\u0090",        "←"),  # same, alternate form
    ("â†'",  "→"),     # U+2192  Right Arrow
    ("âœ•",  "✕"),     # U+2715  Multiplication X  (close button)

    # ── Punctuation ──────────────────────────────────────────────────────────
    ("â€\u0093",   "–"),   # U+2013 En Dash  (â + € + left-double-quote-byte)
    ("â€\u0094",   "—"),   # U+2014 Em Dash
    ("â€¢",   "•"),         # U+2022 Bullet
    ("â€œ",   "\u201C"),    # U+201C Left Double Quotation Mark
    ("â€\u009d", "\u201D"), # U+201D Right Double Quotation Mark  (â€ + 0x9D)
    ("â€˜",   "\u2018"),    # U+2018 Left Single Quotation Mark
    ("â€™",   "\u2019"),    # U+2019 Right Single Quotation Mark
    ("â€º",   "›"),         # U+203A Single Right-Pointing Angle Quotation Mark

    # ── Warning sign ────────────────────────────────────────────────────────
    ("âš ï¸",  "⚠️"),       # U+26A0 + U+FE0F  Warning Sign

    # ── Emoji (4-byte UTF-8 decoded as four Windows-1252 bytes) ─────────────
    ("ðŸ"„",  "📄"),     # U+1F4C4 Page Facing Up
    ("ðŸ"˜",  "📘"),     # U+1F4D8 Blue Book
    ("ðŸ"š",  "📚"),     # U+1F4DA Books
    ("ðŸ"",  "🔍"),      # U+1F50D Magnifying Glass Tilted Left
    ("ðŸ"Ž",  "🔎"),     # U+1F50E Magnifying Glass Tilted Right
    ("ðŸš€",  "🚀"),     # U+1F680 Rocket
    ("ðŸŽ¯",  "🎯"),     # U+1F3AF Direct Hit
    ("ðŸŽ"",  "🎓"),     # U+1F393 Graduation Cap
    ("ðŸ'»",  "💻"),     # U+1F4BB Laptop Computer
    ("ðŸ›¡ï¸", "🛡️"),   # U+1F6E1 Shield + variation selector
    ("ðŸ¤",   "🤝"),     # U+1F91D Handshake
    ("ðŸ'¥",  "👥"),     # U+1F465 Busts in Silhouette
    ("ðŸŒŸ",  "🌟"),     # U+1F31F Glowing Star
    ("ðŸ"—",  "🔗"),     # U+1F517 Link
    ("ðŸ"",  "📝"),      # U+1F4DD Memo
]

fixed = 0
for bad, good in replacements:
    count = content.count(bad)
    if count:
        content = content.replace(bad, good)
        print(f"  [{count:3d}x] replaced  {repr(bad):<20}  →  {repr(good)}")
        fixed += count

# ── Remaining scan: any Windows-1252 mojibake starting with â + € ────────
# These patterns cover variants we haven't explicitly listed:
#   â€" can be either en-dash or em-dash depending on the byte after €.
# At this point both should already be replaced, but log if anything remains.
remaining = [m.start() for m in re.finditer(r'â(?:€|–|—|†|œ|˜|™|º)', content)]
if remaining:
    print(f"\nWARNING: {len(remaining)} possible unfixed mojibake positions remain.")
    for pos in remaining[:10]:
        print(f"  pos {pos}: {repr(content[pos:pos+6])}")
else:
    print("\nNo remaining mojibake detected.")

with open(OUTPUT_FILE, "w", encoding="utf-8") as f:
    f.write(content)

print(f"\nDone – {fixed} substitutions applied. File saved as UTF-8.")
