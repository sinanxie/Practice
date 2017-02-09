//  http://www.codeceo.com/article/java-hashmap-core.html#0-tsina-1-31472-397232819ff9a47a7b7e80a40613cfe1
 
public class HashMap {

    public int hashCode() {
        int h = hash;
        if (h == 0) {
            int off = offset;
            char val[] = value;
            int len = count;
            for (int i = 0; i < len; i++) {
                h = 31 * h + val[off++];
            }
            hash = h;
        }
        return h;
    }

    //  transient keyword:  ignore when object is serielized
    transient Entry[] table;
    public V put(K key, V value) {
        if (key == null) {
            return putForNullKey(value);
        }
        int hash = hash(key.hashCode());
        int i = indexFor(hash, table.length);
        for (Entry<K, V> e = table[i]; e != null; e = e.next) {
            Object k;
            if (e.hash == hash && ((k = e.key) == key || key.equals(k))) {
                V oldValue = e.value;
                e.value = value;
                e.recordAccess(this);
                return oldValue;
            }
        }
        modCount++;
        addEntry(hash, key, value, i);
        return null;
    }
}