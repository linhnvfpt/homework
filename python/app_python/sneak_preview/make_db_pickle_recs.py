from initdata import db
import pickle
for key in db:
    recfile = open(key + '.pkl', 'wb')
    pickle.dump(db[key], recfile)
    recfile.close()