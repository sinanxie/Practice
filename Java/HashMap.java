//  http://www.jianshu.com/p/94fe92ad945b

//  http://www.jiuzhang.com/solutions/mini-cassandra/

/**
 * 本代码由九章算法编辑提供。版权所有，转发请注明出处。
 * - 九章算法致力于帮助更多中国人找到好的工作，教师团队均来自硅谷和国内的一线大公司在职工程师。
 * - 现有的面试培训课程包括：九章算法班，系统设计班，算法强化班，Java入门与基础算法班，Android 项目实战班，Big Data 项目实战班，
 * - 更多详情请见官方网站：http://www.jiuzhang.com/?source=code
 */



class Column {
    public int key;
    public String value;
    public Column(int key, String value) {
        this.key = key;
        this.value = value;
    }
 }
 
public class MiniCassandra {

    private Map<String, NavigableMap<Integer, String>> hash;
    
    public SimpleCassandra() {
        // initialize your data structure here.
        hash = new HashMap<String, NavigableMap<Integer, String>>();
    }
    
    /**
     * @param raw_key a string
     * @param column_start an integer
     * @param column_end an integer
     * @return void
     */
    public void insert(String raw_key, int column_key, String column_value) {
        // Write your code here
        if (!hash.containsKey(raw_key)) {
            hash.put(raw_key, new TreeMap<Integer, String>());
        }
        hash.get(raw_key).put(column_key, column_value);
    }

    /**
     * @param raw_key a string
     * @param column_start an integer
     * @param column_end an integer
     * @return a list of Columns
     */
    public List<Column> query(String raw_key, int column_start, int column_end) {
        // Write your code here
        List<Column> rt = new ArrayList<Column>();
        if (!hash.containsKey(raw_key)) {
            return rt;
        }
        for (Map.Entry<Integer, String> entry :
                hash.get(raw_key).subMap(column_start, true, column_end, true).entrySet()) {
            rt.add(new Column(entry.getKey(), entry.getValue()));
        }
        return rt;
    }
}