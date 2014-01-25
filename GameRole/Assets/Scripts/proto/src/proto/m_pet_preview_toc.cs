namespace proto {
	public class m_pet_preview_toc : Message
	{
		public int err_code = 0;
		public object[] pet_previews;
		public m_pet_preview_toc() {
		}
		public override string getMethodName() {
			return "pet_preview";
		}
		public override string getClassName() {
			return "m_pet_preview_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"},new string[] {"pet_previews", "array", "int"}};
		}
	}
}
