# csharp-DomainSpecificType-demo

A case study in implementing domain-specific types.

## Rationale

### Domain‑Specific Programming

In real‑world programming, certain domains impose strict constraints on data.  
For example, in biomedical informatics, many patient attributes must be non‑negative: a **natural integer** (≥ 0) or a **natural float** (≥ 0.0).

Most programming languages do not natively support domain‑specific types.  
This case study demonstrates how to model such constraints explicitly in C#.

### Type as Constraint

Ada integrates domain constraints directly into its type system.  
Most languages lack this feature, but we can **simulate type constraints** in C# using smart constructors.  
This prevents invalid data from leaking into the core logic and enforces domain rules at the boundary.

Here, we provide an C# implementation of a natural number type as a case study.

## System Requirements

* .NET SDK 10+

## Examples

See [Program.cs](/Program.cs).

## License

MIT License © 2026 ByteBard
