namespace proto {
	public class m_activity_copy_times_toc : Message
	{
		public object[] list;
		public m_activity_copy_times_toc() {
		}
		public override string getMethodName() {
			return "activity_copy_times";
		}
		public override string getClassName() {
			return "m_activity_copy_times_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"list", "array", "p_activity_copy_times"}};
		}
	}
}
