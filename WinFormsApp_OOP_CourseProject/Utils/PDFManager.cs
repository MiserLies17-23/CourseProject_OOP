using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using WinFormsApp_OOP_CourseProject.DTO;
using WinFormsApp_OOP_CourseProject.Model;

namespace WinFormsApp_OOP_CourseProject.Utils
{
    public static class PDFManager
    {
        public static void ConvertToPDF(SectionEnum section, List<ExhibitDTO> exhibits, string filePath)
        {
            // Регистрация лицензии (добавление шрифтов)
            QuestPDF.Settings.License = LicenseType.Community;

            Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(2, Unit.Centimetre);
                    page.PageColor(Colors.White);
                    page.DefaultTextStyle(x => x.FontSize(11).FontFamily("Arial"));

                    page.Header()
                        .AlignCenter()
                        .Text($"Отчёт по разделу: {MuseumSectionExtension.GetDisplayName(section)}")
                        .Bold().FontSize(18).FontColor(Colors.Black);

                    page.Content()
                        .PaddingVertical(10)
                        .Table(table =>
                        {
                            table.ColumnsDefinition(columns =>
                            {
                                columns.RelativeColumn(1); // Id
                                columns.RelativeColumn(3); // Название
                                columns.RelativeColumn(1); // Возраст
                                columns.RelativeColumn(2); // Дата обнаружения
                                columns.RelativeColumn(3); // Описание
                            });

                            table.Header(header =>
                            {
                                header.Cell().Border(0.5f).BorderColor(Colors.Black).AlignCenter().Text("Id").Bold();
                                header.Cell().Border(0.5f).BorderColor(Colors.Black).AlignCenter().Text("Название").Bold();
                                header.Cell().Border(0.5f).BorderColor(Colors.Black).AlignCenter().Text("Возраст").Bold();
                                header.Cell().Border(0.5f).BorderColor(Colors.Black).AlignCenter().Text("Дата обнаружения").Bold();
                                header.Cell().Border(0.5f).BorderColor(Colors.Black).AlignCenter().Text("Описание").Bold();
                            });

                            foreach (var exhibit in exhibits)
                            {
                                table.Cell().Border(0.5f).BorderColor(Colors.Black).AlignCenter()
                                    .Text(exhibit.Id.ToString());
                                table.Cell().Border(0.5f).BorderColor(Colors.Black).AlignLeft()
                                    .Text(exhibit.Name);
                                table.Cell().Border(0.5f).BorderColor(Colors.Black).AlignCenter()
                                    .Text(exhibit.Age.ToString() ?? "");
                                table.Cell().Border(0.5f).BorderColor(Colors.Black).AlignCenter()
                                    .Text(exhibit.DateOfDiscovery);
                                table.Cell().Border(0.5f).BorderColor(Colors.Black).AlignLeft()
                                    .Text(exhibit.Description);
                            }
                        });

                    page.Footer()
                        .AlignCenter()
                        .Text($"Сформировано {DateTime.Now:dd.MM.yyyy HH:mm}")
                        .FontSize(10).FontColor(Colors.Black);
                });
            }).GeneratePdf(filePath);
        }
    }
}
