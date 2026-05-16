import java.util.List;
import java.util.Set;
import java.util.HashSet;

class GottaSnatchEmAll {

    static Set<String> newCollection(List<String> cards) {
        return new HashSet<> (cards);
    }

    static boolean addCard(String card, Set<String> collection) {
        return collection.add(card);
    }

    static boolean canTrade(Set<String> myCollection, Set<String> theirCollection) {
        if (myCollection.isEmpty() || theirCollection.isEmpty()) return false;
        
        Set<String> myCopy = new HashSet<> (myCollection);
        myCollection.removeAll(theirCollection);
        theirCollection.removeAll(myCopy);
        return !myCollection.isEmpty() && !theirCollection.isEmpty();
    }

    static Set<String> commonCards(List<Set<String>> collections) {
        Set<String> commonSet = new HashSet<> (collections.get(0));

        for (var set : collections) {
            commonSet.retainAll(set);
        }

        return commonSet;
    }

    static Set<String> allCards(List<Set<String>> collections) {
        Set<String> totalSet = new HashSet<> ();

        for (var set : collections) {
            totalSet.addAll(set);
        }

        return totalSet;
    }
}
