using System;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        string path = "index.html";
        string[] lines = File.ReadAllLines(path, Encoding.UTF8);

        lines[2645] = "                <a href=\"#about\" class=\"dropdown-toggle\">Profil ▾</a>";
        lines[2654] = "                <a href=\"#work\" class=\"dropdown-toggle nav-filter-link\" data-filter-category=\"all\" data-filter-siklus=\"all\">Artefak ▾</a>";
        lines[2667] = "                <a href=\"#model-guru\" class=\"dropdown-toggle\">Model Guru ▾</a>";
        lines[2686] = "            <span class=\"mobile-dropdown-toggle\">PROFIL <span class=\"arrow\">▾</span></span>";
        lines[2695] = "            <span class=\"mobile-dropdown-toggle\">ARTEFAK <span class=\"arrow\">▾</span></span>";
        lines[2708] = "            <span class=\"mobile-dropdown-toggle\">MODEL GURU <span class=\"arrow\">▾</span></span>";

        lines[2743] = "                    <span>•</span>";
        lines[2745] = "                    <span>•</span>";
        lines[2747] = "                    <span>•</span>";
        lines[2749] = "                    <span>•</span>";
        lines[2751] = "                    <span>•</span>";
        lines[2753] = "                    <span>•</span>";

        lines[2967] = "                    <button class=\"cert-arrow-btn\" onclick=\"openCertDialog('cert-dialog-ust')\" aria-label=\"Lihat Sertifikat\">←</button>";
        lines[2975] = "                    <button class=\"cert-arrow-btn\" onclick=\"openCertDialog('cert-dialog-enerc')\" aria-label=\"Lihat Sertifikat\">➔</button>";
        lines[2983] = "                    <button class=\"cert-arrow-btn\" onclick=\"openCertDialog('cert-dialog-unnes')\" aria-label=\"Lihat Sertifikat\">←</button>";
        lines[3028] = "                        <span>📄</span>";

        lines[3696] = "                        <div class=\"galeri-caption\">Klik untuk memperbesar ↗</div>";
        lines[3698] = "                    <div class=\"galeri-zoom-badge\">🔍</div>";
        lines[3706] = "                        <div class=\"galeri-caption\">Klik untuk memperbesar ↗</div>";
        lines[3708] = "                    <div class=\"galeri-zoom-badge\">🔍</div>";
        lines[3716] = "                        <div class=\"galeri-caption\">Klik untuk memperbesar ↗</div>";
        lines[3718] = "                    <div class=\"galeri-zoom-badge\">🔍</div>";
        lines[3726] = "                        <div class=\"galeri-caption\">Klik untuk memperbesar ↗</div>";
        lines[3728] = "                    <div class=\"galeri-zoom-badge\">🔍</div>";
        lines[3736] = "                        <div class=\"galeri-caption\">Klik untuk memperbesar ↗</div>";
        lines[3738] = "                    <div class=\"galeri-zoom-badge\">🔍</div>";
        lines[3746] = "                        <div class=\"galeri-caption\">Klik untuk memperbesar ↗</div>";
        lines[3748] = "                    <div class=\"galeri-zoom-badge\">🔍</div>";
        lines[3756] = "                        <div class=\"galeri-caption\">Klik untuk memperbesar ↗</div>";
        lines[3758] = "                    <div class=\"galeri-zoom-badge\">🔍</div>";
        lines[3766] = "                        <div class=\"galeri-caption\">Klik untuk memperbesar ↗</div>";
        lines[3768] = "                    <div class=\"galeri-zoom-badge\">🔍</div>";
        lines[3776] = "                        <div class=\"galeri-caption\">Klik untuk memperbesar ↗</div>";
        lines[3778] = "                    <div class=\"galeri-zoom-badge\">🔍</div>";
        lines[3786] = "                        <div class=\"galeri-caption\">Klik untuk memperbesar ↗</div>";
        lines[3788] = "                    <div class=\"galeri-zoom-badge\">🔍</div>";

        lines[3797] = "            <button class=\"lightbox-close\" id=\"lightbox-close\" aria-label=\"Tutup\">✕</button>";
        lines[3873] = "                <h3 class=\"misi-title\">🚀 Misi Keguruan</h3>";
        lines[3878] = "                        <div class=\"misi-icon\">🎯</div>";
        lines[3885] = "                        <div class=\"misi-icon\">💻</div>";
        lines[3892] = "                        <div class=\"misi-icon\">🛡️</div>";
        lines[3899] = "                        <div class=\"misi-icon\">🤝</div>";
        lines[3910] = "                <h3 class=\"kompetensi-title\" style=\"text-align: center;\">🎯 Kompetensi & Karakter</h3>";
        lines[3918] = "                        <div class=\"kompetensi-icon\">📚</div>";
        lines[3926] = "                        <div class=\"kompetensi-icon\">🎓</div>";
        lines[3934] = "                        <div class=\"kompetensi-icon\">👥</div>";
        lines[3942] = "                        <div class=\"kompetensi-icon\">🌟</div>";

        lines[3987] = "                    <button class=\"analisis-modal-close\" id=\"analisis-modal-close\" onclick=\"closeAnalisisModal()\" aria-label=\"Tutup\">✕</button>";

        lines[4244] = "        // 9. Nav Filter Links – apply category/siklus filter when a nav link with data-filter-* is clicked";
        lines[4270] = "        // 10. Galeri Dokumentasi – Lightbox";

        lines[4348] = "                    <h3 class=\"analisis-sec-title\"><span>📘</span> 1. Konteks Pembelajaran</h3>";
        lines[4356] = "                    <h3 class=\"analisis-sec-title\"><span>🎯</span> 2. Tujuan Pengembangan RPP</h3>";
        lines[4369] = "                    <h3 class=\"analisis-sec-title\"><span>🔍</span> 3. Analisis Pendekatan Pembelajaran</h3>";
        lines[4392] = "                    <h3 class=\"analisis-sec-title\"><span>🚀</span> 4. Kelebihan RPP</h3>";
        lines[4403] = "                    <h3 class=\"analisis-sec-title\"><span>⚠️</span> 5. Kekurangan RPP</h3>";
        lines[4413] = "                    <h3 class=\"analisis-sec-title\"><span>📚</span> 6. Kajian Teori PPG yang Terintegrasi</h3>";
        lines[4452] = "                    <h3 class=\"analisis-sec-title\"><span>📝</span> 7. Kesimpulan</h3>";

        lines[4583] = "                    <h3 class=\"analisis-sec-title\"><span>📘</span> 1. Konteks Pembelajaran</h3>";
        lines[4589] = "                    <h3 class=\"analisis-sec-title\"><span>🎯</span> 2. Tujuan Penggunaan Model</h3>";
        lines[4595] = "                    <h3 class=\"analisis-sec-title\"><span>🚀</span> 3. Kelebihan dan Kekurangan</h3>";
        lines[4600] = "                            ${kelebihanList.map(item => `  • ${item}<br>`).join(\"\")}";
        lines[4607] = "                            ${kekuranganList.map(item => `  • ${item}<br>`).join(\"\")}";
        lines[4613] = "                    <h3 class=\"analisis-sec-title\"><span>📚</span> 4. Kajian Teori PPG yang Terintegrasi</h3>";
        lines[4642] = "                    <h3 class=\"analisis-sec-title\"><span>📝</span> Kesimpulan Refleksi</h3>";

        lines[4704] = "                <button class=\"analisis-modal-close\" onclick=\"closeStaticModal('modal-analisis-1')\">✕</button>";
        lines[4723] = "                <button class=\"analisis-modal-close\" onclick=\"closeStaticModal('modal-analisis-2')\">✕</button>";
        lines[4743] = "                <button class=\"analisis-modal-close\" onclick=\"closeStaticModal('modal-analisis-3')\">✕</button>";
        lines[4763] = "                <button class=\"analisis-modal-close\" onclick=\"closeStaticModal('modal-analisis-4')\">✕</button>";

        File.WriteAllLines(path, lines, new UTF8Encoding(false));
    }
}
