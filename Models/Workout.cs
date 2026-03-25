using System.ComponentModel.DataAnnotations;

namespace FlexLog.Models;

public class Workout
{
    public int Id { get; set; } // Първичен ключ за базата данни

    [Required(ErrorMessage = "Моля, въведете име на упражнението")]
    [Display(Name = "Упражнение")]
    public string ExerciseName { get; set; } = string.Empty;

    [Display(Name = "Мускулна група")]
    public string MuscleGroup { get; set; } = string.Empty;

    [Range(0, 500)]
    [Display(Name = "Тежест (кг)")]
    public double Weight { get; set; }

    [Range(1, 100)]
    [Display(Name = "Повторения")]
    public int Reps { get; set; }

    [Range(1, 20)]
    [Display(Name = "Серии")]
    public int Sets { get; set; }

    [DataType(DataType.Date)]
    [Display(Name = "Дата на тренировка")]
    public DateTime Date { get; set; }
}