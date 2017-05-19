namespace WebAssembly.Instructions
{
	/// <summary>
	/// Sign-agnostic multiplication (lower 32-bits).
	/// </summary>
	public class Int32Multiply : SimpleInstruction
	{
		/// <summary>
		/// Always <see cref="OpCode.Int32Multiply"/>.
		/// </summary>
		public sealed override OpCode OpCode => OpCode.Int32Multiply;

		/// <summary>
		/// Creates a new  <see cref="Int32Multiply"/> instance.
		/// </summary>
		public Int32Multiply()
		{
		}
	}
}