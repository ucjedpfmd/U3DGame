namespace proto {
	public class m_pet_soul_merge_tos : Message
	{
		public object[] keep_index;
		public m_pet_soul_merge_tos() {
		}
		public override string getMethodName() {
			return "pet_soul_merge";
		}
		public override string getClassName() {
			return "m_pet_soul_merge_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"keep_index", "array", "int"}};
		}
	}
}
