namespace proto {
	public class m_marry_ceremory_scene_toc : Message
	{
		public int state = 0;
		public object[] ceremory_ids;
		public m_marry_ceremory_scene_toc() {
		}
		public override string getMethodName() {
			return "marry_ceremory_scene";
		}
		public override string getClassName() {
			return "m_marry_ceremory_scene_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"state", "int", "null"},new string[] {"ceremory_ids", "array", "double"}};
		}
	}
}
