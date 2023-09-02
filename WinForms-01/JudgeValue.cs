namespace WinForms_01
{
    public readonly record struct JudgeValue(string Name, double Value, bool Used = true)
    {
        public string Name { get; init; } = Name;
        public double Value { get; init; } = Value;
        public bool Used { get; init; } = Used;
    }

}
